using System;
using System.IO;

namespace BuilderPattern
{
    interface IBuilder
    {
        PictureMetaBuilder WithCoordinate(string coordinate);
        PictureMetaBuilder WithAuthor(string author);
        PictureMetaBuilder WithTime(DateTime time);
        PictureMetaBuilder WithISO(int iso);
        PictureMetaBuilder WithExposure(float exposure);
        PictureMetaBuilder WithPath(DirectoryInfo path);
        PictureMeta BuildPicture();
    }
}
