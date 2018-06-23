using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace MusicApp.Controls
{
    [DataContract]
    public class Person// : BindableBase
    {
        [DataMember]
        public string FriendlyName { get; set; }

        public bool IsProfileImage { get; set; }

        public BitmapImage FaceImage { get; set; }

        public Person(string name, string imagePath)
        {

        }

        private string _imageFileName;
        [DataMember]
        public string ImageFileName
        {
            get
            {
                return _imageFileName;
            }
            set
            {
                //  SetProperty(ref _imageFileName, value);
            }
        }
    }
}
