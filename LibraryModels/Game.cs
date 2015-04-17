﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable()]
    public class Game : Media
    {
        private string developer;
        private string publisher;
        private string platform;
        private bool isCheckedOut;

        //Constructor
        public Game(string t, string d, string pb, string pf)
            : base(t)
        {
            this.Id = AssignId();
            this.Title = t;
            this.developer = d;
            this.publisher = pb;
            this.platform = pf;
            this.isCheckedOut = false;
        }

        public int GetId()
        {
            return this.Id;
        }

        public void SetId(int i)
        {
            this.Id = i;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string t)
        {
            this.Title = t;
        }

        public string GetDeveloper()
        {
            return this.developer;
        }

        public void SetDeveloper(string d)
        {
            this.developer = d;
        }

        public string GetPublisher()
        {
            return this.publisher;
        }

        public void SetPublisher(string p)
        {
            this.publisher = p;
        }

        public string GetPlatform()
        {
            return this.platform;
        }

        public void SetPlatform(string p)
        {
            this.platform = p;
        }

        public void CheckOut()
        {
            this.isCheckedOut = true;
        }

        public void CheckIn()
        {
            this.isCheckedOut = false;
        }

        public bool IsCheckedOut()
        {
            return this.isCheckedOut;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Title:{1}, Developer:{2}, Publisher:{3}, Platform:{4}, Checked Out:{3}", Id, Title, developer, publisher, platform, isCheckedOut);
        }

        // Deserialization method
        public Game(SerializationInfo info, StreamingContext ctxt)
        {
            this.Id = (int)info.GetValue("GameId", typeof(int));
            this.Title = (string)info.GetValue("GameTitle", typeof(string));
            this.developer = (string)info.GetValue("GameDeveloper", typeof(string));
            this.publisher = (string)info.GetValue("GamePublisher", typeof(string));
            this.platform = (string)info.GetValue("Platform", typeof(string));
            this.isCheckedOut = (bool)info.GetValue("CheckedOut", typeof(bool));
        }

        // Serialization method http://tech.pro/tutorial/618/csharp-tutorial-serialize-objects-to-a-file
        public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("GameId", this.Id);
            info.AddValue("GameTitle", this.Title);
            info.AddValue("GameDeveloper", this.developer);
            info.AddValue("GamePublisher", this.publisher);
            info.AddValue("Platform", this.platform);
            info.AddValue("CheckedOut", this.isCheckedOut);
        }
    }
}
