﻿using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a Photo posts in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Yamin Hassan
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        public String Filename { get; set; }        
        // a one line image caption
        public String Caption { get; set; }      
        
        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption) : base(author)
        {           
            this.Filename = filename;
            this.Caption = caption;          
        }
        public PhotoPost(String author) : base(author)
        {

        }
        public int ReturnImageId()
        {
            return ID;
        }
        public override void Display()
        {
            Console.WriteLine("________________________________________________________________________");
            base.Display();
            Console.WriteLine();
            Console.WriteLine($"\tFilename: [{Filename}]");
            Console.WriteLine($"\tCaption: {Caption}");
            Console.WriteLine("__________________________________________________________________________");
        }

        public override string ToString()
        {
            return "\n\t ID: "+ ID +"\t Author Name: " + Username + "\n\t Caption: " + Caption +
                   "\n\t Time" + Timestamp+ "\n\t Likes: " + Likes;
        }
    }
}
