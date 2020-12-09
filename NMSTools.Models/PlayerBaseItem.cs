using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PlayerBaseItem : ModelBase
    {
        private long timestamp;
        private string objectID;
        private long userData;
        private float[] position;
        private float[] up;
        private float[] at;

        [DataMember(Name = "b1:")]
        public long Timestamp
        {
            get => timestamp;
            set
            {
                if ((ReferenceEquals(timestamp, value) != true))
                {
                    timestamp = value;
                    OnPropertyChanged("Timestamp");
                }
            }
        }

        [DataMember(Name = "r<7")]
        public string ObjectID
        {
            get => objectID;
            set
            {
                if ((ReferenceEquals(objectID, value) != true))
                {
                    objectID = value;
                    OnPropertyChanged("ObjectID");
                }
            }
        }

        [DataMember(Name = "CVX")]
        public long UserData
        {
            get => userData;
            set
            {
                if ((ReferenceEquals(userData, value) != true))
                {
                    userData = value;
                    OnPropertyChanged("UserData");
                }
            }
        }

        [DataMember(Name = "wMC")]
        public float[] Position
        {
            get => position;
            set
            {
                if ((ReferenceEquals(position, value) != true))
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        [DataMember(Name = "wJ0")]
        public float[] Up
        {
            get => up;
            set
            {
                if ((ReferenceEquals(up, value) != true))
                {
                    up = value;
                    OnPropertyChanged("Up");
                }
            }
        }

        [DataMember(Name = "aNu")]
        public float[] At
        {
            get => at;
            set
            {
                if ((ReferenceEquals(at, value) != true))
                {
                    at = value;
                    OnPropertyChanged("At");
                }
            }
        }
    }
}