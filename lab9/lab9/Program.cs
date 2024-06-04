using lab9;
using System;

class Program
{
    static void Main(string[] args)
    {
        IPhoto photo = new Photo("Nature.jpg");

        IPhoto photoWithFilter = new FilterDecorator(photo, "Sepia");
        IPhoto photoWithFilterAndFrame = new FrameDecorator(photoWithFilter, "Vintage");

        photoWithFilterAndFrame.Display();
    }
}