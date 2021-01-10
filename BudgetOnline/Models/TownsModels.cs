using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace BudgetOnline.Models
{
    [Serializable]
    [DataContract(Name = "Town")]
    [JsonObject(IsReference = false)]
    public partial class TownsOut
    {
        [DataMember(Name = "ID")]
        public int ID { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        
    }
}