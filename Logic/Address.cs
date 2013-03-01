﻿namespace Logic {
    public class Address {
        public int Id { get; set; }

        public string StreetAddress { get; set; }

        public string StreetAddress2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public  virtual OwnedEntity OEntity { get; set; }
    }
}