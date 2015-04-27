using LibraryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryViews.Controllers
{
    class CdsController
    {
        public static ListView PopulateMainCdsViewList(ListView l, List<Media> mediaItems)
        {
            List<Media> mediaFromFile = mediaItems;

            foreach (Media c in mediaFromFile)
            {
                if (c is Cd)
                {
                    Cd itemAsCd = (Cd)c;
                    ListViewItem itm;
                    string[] bk = new String[4];

                    bk[0] = itemAsCd.Id.ToString();
                    bk[1] = itemAsCd.Title;
                    bk[2] = itemAsCd.Performer;
                    // Is it in stock?
                    if (itemAsCd.IsCheckedOut())
                    {
                        bk[3] = "Out of Stock";
                    }
                    else
                    {
                        bk[3] = "In Stock";
                    }
                    itm = new ListViewItem(bk);
                    l.Items.Add(itm);
                }
            }
            return l;
        }

        public static List<Media> GetMediaList()
        {
            ObjectSerializer serializer = new ObjectSerializer();
            ObjectToSerialize serializedMedia = new ObjectToSerialize();
            serializedMedia = serializer.DeSerializeObject("media.txt");

            List<Media> mediaFromFile = new List<Media>();
            mediaFromFile = serializedMedia.Media;

            return mediaFromFile;
        }

        public static void SaveMedia(List<Media> mediaList)
        {
            List<Media> newMediaList = mediaList;
            //foreach (Media item in mediaList)
            //{
            //    if (item is Book)
            //    {
            //        newMediaList.Add((Cd)item);
            //    }
            //}
            ObjectSerializer serializer = new ObjectSerializer();
            ObjectToSerialize newSerializedMedia = new ObjectToSerialize();
            newSerializedMedia.Media = newMediaList;
            serializer.SerializeObject("media.txt", newSerializedMedia);
        }

        public static bool AddCdToNewList(Cd c)
        {
            bool success = false;
            List<Media> mediaNew = new List<Media>();
            mediaNew.Add(c);

            ObjectSerializer serializer = new ObjectSerializer();
            ObjectToSerialize serializeMedia = new ObjectToSerialize();
            serializeMedia.Media = mediaNew;
            serializer.SerializeObject("media.txt", serializeMedia);
            success = true;

            return success;
        }

        public static List<Media> DeleteCd(int i, List<Media> media)
        {
            //bool success = false;
            int id = i;
            int counter = 0;

            foreach (Media c in media)
            {
                if (c.Id == i)
                {
                    media.RemoveAt(counter);
                    break;
                }
                counter++;
            }

            return media;
        }

        public static List<Media> UpdateCd(int i, string t, string pf, string pd, string pb, List<Media> m)
        {

            int id = i;
            int counter = 0;

            try
            {
                Cd updatedCd = new Cd(i, t, pf, pd, pb);
                List<Media> media = new List<Media>();
                media = m;

                foreach (Media c in media)
                {
                    if (c.Id == i)
                    {
                        media.RemoveAt(counter);
                        media.Insert(counter, updatedCd);
                        break;
                    }
                    counter++;
                }

                return media;
            }

            catch
            {
                return m;
            }
        }
    }
}
