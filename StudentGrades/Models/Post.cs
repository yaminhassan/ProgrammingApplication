using StudentGrades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentGrades
{ 
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// </author>
    public class Post
    {
        
        // Likes on the post
        public int Likes { get; set; }

        // ID of the post
        public int ID { get; set; }
        // username of the post's author
       
        public String Username { get; set; }
        // Date and time of the Post
        public DateTime Timestamp { get; }
        // Comments on the posts
        public List<Comments> Comments { get; set; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>


        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            Likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (Likes > 0)
            {
                Likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            Comments comment = new Comments(text);

        }
        //add comment to the list
        public void AddCoomentToList(Comments comment)
        {
            Comments.Add(comment);
        }

        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"\t\t ID: {ID}");
            Console.WriteLine($"\t\t Author: {Username}");            
            Console.WriteLine($"\t\t Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (Likes >= 0)
            {
                Console.WriteLine($"\t\tLikes:  {Likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (Comments.Count == 0)
            {
                Console.WriteLine("\t\tNo comments.");
            }
            else
            {
                Console.WriteLine($"\t\t{Comments.Count}  comment(s). Click here to view.");
                int counter = 0;
                
                foreach (Comments comment in Comments)
                {
                    
                    Console.WriteLine($"\t {++counter}: {comment}");
                }
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}