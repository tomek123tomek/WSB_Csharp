using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DelegatyItp {


    [CustomAttribute("JG", " Foolin ' around with custom attributes ... ")]
    class Configuration {

        public int MaxUserCount { get; set; } 
        public int MaxUserNameLength { get; set; } 
        public int MinUserNameLength { get; set; } 
        public int MaxUserPasswordLength { get; set; } 
        public int MinUserPasswordLength { get; set; }

        public static void Save(Configuration configuration, string configFilePath) {
            
            
            throw new NotImplementedException();
        }

        public static Configuration load(string configFilePath) {
            return null;
        }


        public static void Save(Configuration configuration, string configFilePath) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Configuration));
            using (var streamWriter = new System.IO.StreamWriter(configFilePath)) {
                xmlSerializer.Serialize(streamWriter, configuration);
            }
        }


        public static Configuration Load ( string configFilePath )
        {
            XmlSerializer xmlSerializer = new XmlSerializer ( typeof ( Configuration ));
            using ( var streamReader = new System.IO.StreamReader ( configFilePath ))
            {
                return ( Configuration ) xmlSerializer . Deserialize ( streamReader );
            }
        }

    }
}
