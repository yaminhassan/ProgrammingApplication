using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Yamin Hassan    
    ///</author> 
    public class NewsFeed
    {
        private readonly List<MessagePost> messages;
        private readonly List<PhotoPost> photos;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            messages = new List<MessagePost>();
            photos = new List<PhotoPost>();
        }
        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>     
        public void AddMessagePost(MessagePost message)
        {
            if(message == FindMessageById(message.ID))
            {
                Console.WriteLine("Please enter unique Id as it shows as Duplicate");
            }
            messages.Add(message);
        }
        // itererate the list of message the specific author name
        public MessagePost MessageByName(string name)
        {
            foreach(MessagePost message in messages)
            {
                if(message.Username.Contains(name))
                {
                    return message;
                }
            }
            return null;
        }
        // itererate the list of message the specific author name
        public PhotoPost PhotoeByName(string name)
        {
            foreach (PhotoPost photo in photos)
            {
                if (photo.Username.Contains(name))
                {
                    return photo;
                }
            }
            return null;

        }
        /// <summary>
        /// Find the Message Post with help of the id and return it
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MessagePost FindMessageById(int id)
        {
            foreach (MessagePost message in messages)
            {
                if (message.ID == id)
                {
                    return message;
                }
            }
            
            return null;
        }
        /// <summary>
        /// Find the Photo with the help od id number
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PhotoPost FindPhotoById(int id)
        { 
            foreach (PhotoPost photo in photos)
            {
                if (photo.ID == id)
                {
                    return photo;
                }
            }            
            return null;

        }
        public void FintPostByAuthor(string name)
        {
            MessagePost message = MessageByName(name);
            if(message !=null)
            {
                Console.WriteLine(message);
            }
            PhotoPost photo = PhotoeByName(name);
            if(photo != null)
            {
                Console.WriteLine(photo);
            }
        }
        //find Photo post or Message post by their unique id
        public void FindPost(int id)
        {
            MessagePost post = FindMessageById(id);
            if (post != null)
            {
                Console.WriteLine(post);
            }

            PhotoPost photo = FindPhotoById(id);
            if (photo != null)
            {
                Console.WriteLine(photo);
            }
            
            
                Console.WriteLine("Product not found! Please enter valid ID");
            
        }
        //Remove the id from the list
        public void RemovePost(int id)
        {
            MessagePost post = FindMessageById(id);
            if(post != null)
            {
                messages.Remove(post);
            }

            PhotoPost photo = FindPhotoById(id);
            if (photo != null)
            {
                photos.Remove(photo);
            }
            else
            {
                Console.WriteLine("Please enter valid id number");
            }
        }        
        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            if (photo == FindPhotoById(photo.ID))
            {
                Console.WriteLine("Please enter unique Id as it shows as Duplicate");
            }
            photos.Add(photo);
        }
        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (MessagePost message in messages)
            {
                message.Display();
                Console.WriteLine();   // empty line between posts
            }
            // display all photos
            foreach (PhotoPost photo in photos)
            {
                photo.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
        // add comment to the post
        public void Addcomment(string comment, int id)
        {
            PhotoPost post = FindPhotoById(id);            
            if (post != null)
            {
                 post.AddComment(comment);
            }

            MessagePost message = FindMessageById(id);
            if (message != null)
            {
                message.AddComment(comment);
            }
            else
            {
                Console.WriteLine("Please enter Valid ID number");
            }
        }
        // Like message post
        public void LikePost(int id)
        {
            MessagePost message = FindMessageById(id);
            {
                if (message != null)
                {
                    message.Like();
                }
            }

            PhotoPost post = FindPhotoById(id);
            {
                if (post != null)
                {
                    post.Like();
                }
                else
                {
                    Console.WriteLine("Please Enter Valid ID");
                }
            }            
        }
        // UnLike the post in the list
        public void UnLikePost(int id)
        {
            MessagePost message = FindMessageById(id);
            {
                if (message != null)
                {
                    message.Unlike();
                }
            }

            PhotoPost post = FindPhotoById(id);
            {
                if (post != null)
                {
                    post.Unlike();
                }
                else
                {
                    Console.WriteLine("Please Enter Valid ID");
                }
            }
        }
        //Display by date 
        public void DisplayByDate()
        {
            foreach (MessagePost message in messages)
            {
                Console.WriteLine($"\tMessage ID: {message.ID} \n\t Message Time: {message.Timestamp}");
            }
            
            foreach (PhotoPost photo in photos)
            {
                Console.WriteLine($"\tMessage ID: {photo.ID} \n\t Message Time: {photo.Timestamp}");
            }            
        }
        // Display by Author Name
        public void DisplayByAuthor()
        {
            int counter = 0;
            foreach (MessagePost message in messages)
            {
                
                Console.WriteLine($"{++counter}: Message Id: {message.ID} \n\t Author: {message.Username}");   
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                Console.WriteLine($"{++counter}: Message Id: {photo.ID} \n\t Author: {photo.Username}");
            }
        }
    }
}
