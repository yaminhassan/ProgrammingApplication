using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class NetworkApplication
    {
        NewsFeed newsFeed = new NewsFeed();
        public string[] options = new string[] { "Add Comment", "Display by Date", "Display by author", "Remove Post", 
                                                 "Display All", "Post Image", "Post Message", "InPut Name", "Like Post", "UnLike Post","Find Post"};
        public NetworkApplication()
        {
            
        }
        public void DisplayMenu()
        {
            ConsolHelper.PrintHeader(options);
            Console.WriteLine("Please choose from One of the Options above");
            int choice = ConsolHelper.GetInput1();
            if (choice > 0 && choice < options.Length+1)
            {
                Choice(choice);
            }
            else
            {
                Console.WriteLine("\t Please Enter from the options Above");
                DisplayMenu();
            }


        }
        public void Choice(int choice)
        {
            switch(choice)
            {
                case 1:
                    AddComment();
                    break;
                case 2:
                    DisplayByDate();
                    break;
                case 3:
                    DisplayByAuthor();
                    break;
                case 4:
                    RemovePost();
                    break;
                case 5:
                    DisplayAll();
                    break;
                case 6:
                    PostImage();
                    break;
                case 7:
                    PostMessage();
                    break;
                case 8:
                    Inputname();
                    break;
                case 9:
                    LikePost();
                    break;
                case 10:
                    UnLikePost();
                    break;
                case 11:
                    FindPost();
                    break;
            }            
        }

        private void FindPost()
        {
            Console.WriteLine("\t Pleae enter the Id You like to find");
            int id = ConsolHelper.GetInput1();
            newsFeed.FindPost(id);
            DisplayMenu();
        }

        private void UnLikePost()
        {
            Console.WriteLine("\t Pleae enter the Id You like to like");
            int id = ConsolHelper.GetInput1();
            newsFeed.UnLikePost(id);
            DisplayMenu();
        }

        private void LikePost()
        {
            Console.WriteLine("\t Pleae enter the Id You like to Unlike");
            int id = ConsolHelper.GetInput1();
            newsFeed.LikePost(id);
            DisplayMenu();
        }

        private void Inputname()
        {
            Console.WriteLine("Please enter the Author name");
            string name = Console.ReadLine().ToLower().Trim();
            newsFeed.FintPostByAuthor(name);
            DisplayMenu();
        }

        private void PostMessage()
        {
            Console.WriteLine("\t\t This is Post a Message\n\t\t" +
                               "Please enter the Autor name");
            string name = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("\t\tPlease Enter the Message you like to post");
            string message = Console.ReadLine().ToLower().Trim();            
            if(name.Length == 0)
            {
                Console.WriteLine("Please enter author name as it cannot be empty");
                PostMessage();
            }
            else
            {
                MessagePost post = new MessagePost(name, message);
                newsFeed.AddMessagePost(post);
                Console.WriteLine($"\t\t {post}");
            }
            DisplayMenu();
        }

        private void PostImage()
        {
            Console.WriteLine("\t\t This is Post a Message\n\t\t" +
                               "Please enter the Autor name");
            string name = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("\t\tPlease Enter the file name");
            string fileName = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Please enter the caption of the Photo");
            string caption = Console.ReadLine().ToLower().Trim();           
            if (name.Length == 0)
            {
                Console.WriteLine("Please enter author name as it cannot be empty");
                PostImage();
            }
            else
            {
                PhotoPost post = new PhotoPost(name, fileName, caption);
                newsFeed.AddPhotoPost(post);                
            }
            DisplayMenu();
        }
        // Display all Mesage and Photo post in the list.
        private void DisplayAll()
        {
            newsFeed.Display();
            DisplayMenu();
        }
        // Remove post method lead to two choices of post message and photo post.
        private void RemovePost()
        {
           
            Console.WriteLine("Please select ID of the post you would like to remove");
            int id = ConsolHelper.GetInput1();
            if (newsFeed.FindMessageById(id) != null)
            {
                newsFeed.RemovePost(id);
                Console.WriteLine($"The ID: {id} is removed from data base");
                DisplayMenu();
            }
            else if (newsFeed.FindPhotoById(id) != null)
            {
                newsFeed.RemovePost(id);
                Console.WriteLine($"The ID: {id} is removed from data base");
                DisplayMenu();
            }
            else
            {
                Console.WriteLine("\t Please enter valid id");
                DisplayMenu();
            }

        }
        // Display by author Name       
        private void DisplayByAuthor()
        {
            newsFeed.DisplayByAuthor();
            DisplayMenu();
        }
        // Display post by the Date
        private void DisplayByDate()
        {
            newsFeed.DisplayByDate();
            DisplayMenu();
        }
        // Add the comments to the particular post
        private void AddComment()
        {
            Console.WriteLine("Please enter the id of the post you would like to comment");
            int id = ConsolHelper.GetInput1();
            if(newsFeed.FindMessageById(id) != null)
            {
                Console.WriteLine("Please write the comment");
                string comment = Console.ReadLine();
                newsFeed.Addcomment(comment,id);
                DisplayMenu();
            }
             else if(newsFeed.FindPhotoById(id) != null)
            {
                Console.WriteLine("Please write the comment");
                string comment = Console.ReadLine();
                newsFeed.Addcomment(comment, id);
                DisplayMenu();
            }
            else
            {
                Console.WriteLine("\tPlease enter Valid ID");
                DisplayMenu();
            }
        }
            
    }
}
