using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        // public string ReadVideoTitle()   // original method
        // outsource that to an external FileReader class with Interface
        // var str = File.ReadAllText("video.txt"); -> mocking, filereader.cs

        #region Dependency Injection via Method Parameter
        //public string ReadVideoTitle(IFileReader fileReader)
        //{
        //    var str = fileReader.Read("video.txt");
        //    var video = JsonConvert.DeserializeObject<Video>(str);
        //    if (video == null)
        //        return "Error parsing the video.";
        //    return video.Title;
        //}
        #endregion

        #region Dependency Injection via Properties
        //public IFileReader FileReader { get; set; }

        //public VideoService()
        //{
        //    FileReader = new FileReader();
        //}
        #endregion

        #region Dependency Injection via Constructor
        private IFileReader _fileReader;

        //public VideoService()
        //{
        //    _fileReader = new FileReader();
        //}

        public VideoService(IFileReader fileReader = null)
        {
            _fileReader = fileReader ?? new FileReader();
        }
        #endregion

        #region Dependemcy Injection via Properties
        //public string ReadVideoTitle()
        //{
        //    var str = FileReader.Read("video.txt");
        //    var video = JsonConvert.DeserializeObject<Video>(str);
        //    if (video == null)
        //        return "Error parsing the video.";
        //    return video.Title;
        //}
        #endregion

        #region Dependemcy Injection via Constructor
        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }
        #endregion

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            using (var context = new VideoContext())
            {
                var videos =
                    (from video in context.Videos
                     where !video.IsProcessed
                     select video).ToList();

                foreach (var v in videos)
                    videoIds.Add(v.Id);

                return String.Join(",", videoIds);
            }
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}