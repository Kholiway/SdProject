﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logic {
    public class House : IObjectState {
        public int Id { get; set; }

        public string HeatingType { get; set; }

        public int StoryCount { get; set; }

        public int RoomCount { get; set; }

        public Double FloorSpace { get; set; }

        public virtual Address Address { get; set; }

        public virtual BaseComponent Base { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}