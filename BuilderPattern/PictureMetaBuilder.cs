using System;
using System.IO;

namespace BuilderPattern
{
    class PictureMetaBuilder : IBuilder
    {
        private string _coordinate;
        private string _author;
        private DateTime _time;
        private int _ISO;
        private float _exposure;
        private DirectoryInfo _path;        

        public PictureMetaBuilder WithAuthor(string author)
        {
            _author = author;
            return this;
        }

        public PictureMetaBuilder WithCoordinate(string coordinate)
        {
            _coordinate = coordinate;
            return this;
        }

        public PictureMetaBuilder WithExposure(float exposure)
        {
            _exposure = exposure;
            return this;
        }

        public PictureMetaBuilder WithISO(int iso)
        {
            _ISO = iso;
            return this;
        }

        public PictureMetaBuilder WithPath(DirectoryInfo path)
        {
            _path = path;
            return this;
        }

        public PictureMetaBuilder WithTime(DateTime time)
        {
            _time = time;
            return this;
        }

        public PictureMeta BuildPicture()
        {
            return new PictureMeta()
            {
                coordinate = _coordinate,
                author = _author,
                time = _time,
                ISO = _ISO,
                exposure = _exposure,
                path = _path
            };
        }
    }
}
