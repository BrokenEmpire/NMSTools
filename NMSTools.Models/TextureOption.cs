using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class TextureOption : ModelBase
    {
        private string textureOptionGroupName;
        private string textureOptionName;

        [DataMember(Name = "@6c")]
        public string TextureOptionGroupName
        {
            get => textureOptionGroupName;
            set
            {
                if ((ReferenceEquals(textureOptionGroupName, value) != true))
                {
                    textureOptionGroupName = value;
                    OnPropertyChanged("TextureOptionGroupName");
                }
            }
        }

        [DataMember(Name = "=Cv")]
        public string TextureOptionName
        {
            get => textureOptionName;
            set
            {
                if ((ReferenceEquals(textureOptionName, value) != true))
                {
                    textureOptionName = value;
                    OnPropertyChanged("TextureOptionName");
                }
            }
        }
    }
}