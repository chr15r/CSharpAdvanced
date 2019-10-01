﻿using System;

namespace Delegates
{

    public class PhotoProcessor
    {

        // Custom delegate
        // public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {

            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
