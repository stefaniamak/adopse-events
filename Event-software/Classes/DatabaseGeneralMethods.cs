﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbstuff;

namespace itHappens.Classes
{
    class DatabaseGeneralMethods
    {
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        public static int returnUsersIDWhenIsLogedIn(String username)
        {
            MySqlConnection con;
            String result = "";

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from users where username= '" + username + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    result = dataReader.GetString(0);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return Convert.ToInt32(result);

        }

        public static int ReturnNumberOfUserEvents(int userid)
        {
            MySqlConnection con;
            int num = 0;

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select COUNT(*) from event where ownerID=" + userid + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    num = dataReader.GetInt32(0);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error Number Of User Events");
            }


            return num;

        }


        public static void GetUserEventIds(int userid)
        {
            MySqlConnection con;

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from event where ownerID=" + userid + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Controllers.UIController.eventIDList.Add(dataReader.GetInt32(0));
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error id Of User Events");
            }

        }

        public static void GetUserEventCategoryIds(int userid)
        {
            MySqlConnection con;

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select categoryID from event where ownerID=" + userid + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Controllers.UIController.eventCategoryIDList.Add(dataReader.GetString(0));
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error CategoryID Of User Events");
            }

        }


        public static String GetCategoryColorOfEvent(int categoryid)
        {
            MySqlConnection con;
            String result = "";

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select color from categories where id=" + categoryid + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    result = dataReader.GetString(0);
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error CategoryID Of User Events");
            }

            return result;
        }

        public static bool checkIfExistsInDatabaseInUsers(String variable, String s)
        {
            MySqlConnection con;
            bool flag = false; ;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select " + variable + " from users";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (s.Equals(dataReader.GetString(0)))
                    {
                        flag = true;
                    }
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return flag;
        }

        public static bool checkIfExistsInDatabaseWithAnotherID(int Uid, String variable, String s)
        {
            MySqlConnection con;
            bool flag = false;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select " + variable + ",id from users";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    if (s.Equals(dataReader.GetString(0)) && Uid != dataReader.GetInt32(1))
                    {
                        flag = true;
                    }
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return flag;
        }


        public static String ReturnUsersPassword(String usern)
        {
            MySqlConnection con;
            String pass = "";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select password from users where username= '" + usern + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    pass = dataReader.GetString(0);

                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return pass;
        }


        public static int ReturnIdOfAray(String area)
        {
            int areaId = 0;
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from area where country= '" + area + "'";

                command = new MySqlCommand(queryString, con);


                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    areaId = Convert.ToInt32(dataReader.GetString(0));
                }


                con.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return areaId;
        }

        public static int ReturnAgeOfUser(String user, String pass)
        {
            MySqlConnection con;
            int age = 0;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select age from users where username='" + user + "' and password='" + pass + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    age = dataReader.GetInt32(0);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return age;
        }

        public static bool CheckIfEventBelongsToLoggedInUser(int eventid)
        {
            MySqlConnection con;
            bool result = false;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select ownerID from event where id=" + eventid + "";
                Console.WriteLine("EventID: "+eventid);
                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (UIs.anna.LogInPage.userId == dataReader.GetInt32(0))
                    {
                        result = true;
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return result;
        }

        public static string returnTitleOfEvent(int eventid)
        {
            MySqlConnection con;
            string title = "";

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select title from event where id=" + eventid + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    title = dataReader.GetString(0);
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error CategoryID Of User Events");
            }
            return title;
        }

        public static string returnImageOfEvent(int eventid)
        {
            MySqlConnection con;
            string image = "";

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select image from event where eventID=" + eventid + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (!dataReader.IsDBNull(0))
                        image = dataReader.GetString(0);
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error CategoryID Of User Events");
            }
            return image;
        }

    }
}
