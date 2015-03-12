﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryModels;

namespace LibraryViews.Controllers
{
    public class CustomersController
    {
        public static ListView PopulateMainCustomersViewList(ListView l)
        {
            List<Customer> customersFromFile = new List<Customer>();

            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize serializedCustomers = new CustomerObjectToSerialize();
            serializedCustomers = serializer.DeSerializeObject("customers.txt");
            customersFromFile = serializedCustomers.Customers;

            foreach (Customer c in customersFromFile)
            {
                ListViewItem itm;
                string[] cust = new String[4];

                cust[0] = c.GetAccountNumber().ToString();
                cust[1] = c.GetFirstName() + " " + c.GetLastName();
                cust[2] = c.GetPhoneNumber();
                cust[3] = c.GetEmailAddress();

                itm = new ListViewItem(cust);
                l.Items.Add(itm);
            }
            return l;
        }


        public static List<Customer> getCustomersList()
        {
            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize serializedCustomers = new CustomerObjectToSerialize();
            serializedCustomers = serializer.DeSerializeObject("customers.txt");

            List<Customer> customersFromFile = new List<Customer>();
            customersFromFile = serializedCustomers.Customers;

            return customersFromFile;
        }

        public static ComboBox PopulateCustomersComboBox(ComboBox c)
        {
            List<Customer> customersFromFile = new List<Customer>();

            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize serializedCustomers = new CustomerObjectToSerialize();
            serializedCustomers = serializer.DeSerializeObject("customers.txt");
            customersFromFile = serializedCustomers.Customers;

            foreach (Customer cus in customersFromFile)
            {
                c.Items.Add(cus.GetAccountNumber().ToString() + " " + cus.GetName());
            }
            return c;
        }

        public static bool AddCustomerToExistingList(Customer c)
        {
            bool success = false;
            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize serializedCustomers = new CustomerObjectToSerialize();
            serializedCustomers = serializer.DeSerializeObject("customers.txt");

            List<Customer> customersFromFile = new List<Customer>();
            customersFromFile = serializedCustomers.Customers;
            customersFromFile.Add(c);

            CustomerObjectToSerialize newSerializedCustomers = new CustomerObjectToSerialize();
            newSerializedCustomers.Customers = customersFromFile;
            serializer.SerializeObject("customers.txt", newSerializedCustomers);
            success = true;

            return success;  
        }

        public static bool AddCustomerToNewList(Customer c)
        {
            bool success = false;
            List<Customer> customersNew = new List<Customer>();
            customersNew.Add(c);

            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize serializeCustomer = new CustomerObjectToSerialize();
            serializeCustomer.Customers = customersNew;
            serializer.SerializeObject("customers.txt", serializeCustomer);
            success = true;

            return success;
        }

        public static Customer GetCustomer(int id)
        {
            List<Customer> customersFromFile = new List<Customer>();
            int index = 0;

            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize serializedCustomers = new CustomerObjectToSerialize();
            serializedCustomers = serializer.DeSerializeObject("customers.txt");
            customersFromFile = serializedCustomers.Customers;

            foreach (Customer c in customersFromFile)
            {
                if (c.GetAccountNumber() == id)
                {
                    break;
                }
                index++;
            }

            return customersFromFile[index];     
        }

        public static bool DeleteCustomer(int i)
        {
            bool success = false;
            int id = i;
            int counter = 0;

            List<Customer> customers = new List<Customer>();
            customers = getCustomersList();

            foreach (Customer c in customers)
            {
                if (c.GetAccountNumber() == i)
                {
                    customers.RemoveAt(counter);
                    break;
                }
                counter++;
            }

            CustomerSerializer serializer = new CustomerSerializer();
            CustomerObjectToSerialize newSerializedCustomers = new CustomerObjectToSerialize();
            newSerializedCustomers.Customers = customers;
            serializer.SerializeObject("customers.txt", newSerializedCustomers);
            success = true;

            return success;
        }

        public static bool UpdateCustomer(int a, string f, string l, string p, string e)
        {

            bool success = false;
            int id = a;
            int counter = 0;

            try
            {Customer updatedCustomer = new Customer(a, f, l, p, e);
                List<Customer> customers = new List<Customer>();
                customers = getCustomersList();

                foreach (Customer c in customers)
                {
                    if (c.GetAccountNumber() == a)
                    {
                        customers.RemoveAt(counter);
                        customers.Insert(counter, updatedCustomer);
                        break;
                    }
                    counter++;
                }

                CustomerSerializer serializer = new CustomerSerializer();
                CustomerObjectToSerialize newSerializedCustomers = new CustomerObjectToSerialize();
                newSerializedCustomers.Customers = customers;
                serializer.SerializeObject("customers.txt", newSerializedCustomers);
                success = true;

                return success;
            }

            catch
            {
                success = false;
                return success;
            }
        }
    }
}
