using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SocialMediaApp
{
    public class LocalUsersStorage
    {
        private static readonly string _filePath = "users.xml";
        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<User>));


        public static void InitXmlStorage() { 

            // Check if the XML file exists
            if (!File.Exists(_filePath))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;

                XmlWriter writer = XmlWriter.Create(_filePath,settings);
                writer.WriteStartDocument();

                // Use the WriteStartElement method to set the root element
                writer.WriteStartElement("ArrayOfUser");

                // Write the XML for the user data here...

                // Close the root element and the XML document
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
 
        }

        public static bool AddUser(User user)
        {
            // Deserialize the existing XML file into a list of User objects
            List<User> userList = GetUsers();

            if (userList.Exists((u) => user.Username == u.Username))
            {
                return false;
            }
            // Add the new user to the list of users
            userList.Add(user);

            SerializeUserList(userList);

            return true;
        }

        // Method to delete a user from an XML file
        public static bool DeleteUser(string username)
        {
            // Deserialize the XML file into a list of User objects
            List<User> userList = GetUsers();

            // Find the user and remove it from the list
            User? userToDelete = userList.FirstOrDefault(u => u.Username == username);

            if (userToDelete == null)
            {
                return false;
            }
            userList.Remove(userToDelete);

            SerializeUserList(userList);

            return true;
        }

        private static void SerializeUserList(List<User> userList)
        {
            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                _serializer.Serialize(stream, userList);
            }
        }
        public static List<User> GetUsers()
        {
            // Deserialize the XML file into a list of User objects
            List<User> users = new List<User>();
            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                users = (List<User>)_serializer.Deserialize(stream);
            }

            return users;
        }

        public static User? GetUser(string username, string password) 
        {
            return GetUsers().FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public static bool UserExists(string username)
        {
            return GetUsers().Exists(u => u.Username == username);
        }

    }
}
