using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public static class PropertiesData
    {
        private static List<PropertyDetails> properties = new List<PropertyDetails>
        {
            new PropertyDetails()
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350,
                Description = "A charming cottage with stunning sea views",
                Amenities = new List<string> { "Wi-Fi", "Kitchen", "Parking" },
                BookedDates = new List<DateTime> { new DateTime(2023, 7, 15), new DateTime(2023, 8, 5) }
            },
            new PropertyDetails()
            {
                Id = 2,
                Name = "Saffron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Description = "An elegant home in the English countryside",
                Amenities = new List<string> { "Garden", "Library", "Indoor Pool" },
                BookedDates = new List<DateTime> { new DateTime(2023, 6, 20), new DateTime(2023, 9, 10) }
            },
            new PropertyDetails()
            {
                Id = 3,
                Name = "Alpine Retreat",
                Blurb = "Escape to the Alps in this cozy retreat",
                Location = "Swiss Alps",
                NumberOfBedrooms = 3,
                CostPerNight = 400,
                Description = "A charming chalet with breathtaking mountain views",
                Amenities = new List<string> { "Sauna", "Ski Storage", "Terrace" },
                BookedDates = new List<DateTime> { new DateTime(2023, 8, 1), new DateTime(2023, 8, 15) }
            },
            new PropertyDetails()
            {
                Id = 4,
                Name = "Tropical Paradise House",
                Blurb = "Experience paradise in this tropical getaway",
                Location = "Bora Bora, French Polynesia",
                NumberOfBedrooms = 4,
                CostPerNight = 800,
                Description = "A luxurious villa surrounded by turquoise waters",
                Amenities = new List<string> { "Private Beach", "Infinity Pool", "Snorkeling Gear" },
                BookedDates = new List<DateTime> { new DateTime(2023, 7, 5), new DateTime(2023, 7, 20) }
            },
            new PropertyDetails()
            {
                Id = 5,
                Name = "Modern City Loft",
                Blurb = "Chic loft in the heart of downtown",
                Location = "New York City, USA",
                NumberOfBedrooms = 1,
                CostPerNight = 350,
                Description = "An urban oasis with skyline views",
                Amenities = new List<string> { "Fitness Center", "Roof Terrace", "Concierge" },
                BookedDates = new List<DateTime> { new DateTime(2023, 6, 1), new DateTime(2023, 6, 10) }
            },
            new PropertyDetails()
            {
                Id = 6,
                Name = "Rustic Mountain Cabin",
                Blurb = "Escape to nature in this rustic cabin",
                Location = "Rocky Mountains, USA",
                NumberOfBedrooms = 2,
                CostPerNight = 300,
                Description = "Cozy cabin surrounded by pine trees",
                Amenities = new List<string> { "Wood-Burning Fireplace", "Hiking Trails", "Deck" },
                BookedDates = new List<DateTime> { new DateTime(2023, 9, 15), new DateTime(2023, 10, 1) }
            },
            new PropertyDetails()
            {
                Id = 7,
                Name = "Historic Castle",
                Blurb = "Live like royalty in this historic castle",
                Location = "Edinburgh, Scotland",
                NumberOfBedrooms = 10,
                CostPerNight = 1500,
                Description = "A castle with centuries of history",
                Amenities = new List<string> { "Great Hall", "Moat", "Tapestries" },
                BookedDates = new List<DateTime> { new DateTime(2023, 8, 20), new DateTime(2023, 9, 5) }
            },
            new PropertyDetails()
            {
                Id = 8,
                Name = "Zen Garden Retreat",
                Blurb = "Find peace in this tranquil garden retreat",
                Location = "Kyoto, Japan",
                NumberOfBedrooms = 3,
                CostPerNight = 600,
                Description = "Traditional Japanese retreat with a beautiful garden",
                Amenities = new List<string> { "Tea Room", "Koi Pond", "Meditation Space" },
                BookedDates = new List<DateTime> { new DateTime(2023, 7, 10), new DateTime(2023, 7, 25) }
            },
            new PropertyDetails()
            {
                Id = 9,
                Name = "Desert Oasis Villa",
                Blurb = "Escape to the desert in this luxurious villa",
                Location = "Scottsdale, Arizona",
                NumberOfBedrooms = 6,
                CostPerNight = 900,
                Description = "A villa surrounded by cacti and stunning desert landscapes",
                Amenities = new List<string> { "Swimming Pool", "Outdoor Kitchen", "Star Gazing" },
                BookedDates = new List<DateTime> { new DateTime(2023, 5, 15), new DateTime(2023, 6, 5) }
            },
            new PropertyDetails()
            {
                Id = 10,
                Name = "Snowy Mountain Chalet",
                Blurb = "Cozy chalet with stunning mountain views",
                Location = "Whistler, Canada",
                NumberOfBedrooms = 4,
                CostPerNight = 700,
                Description = "Experience winter magic in this mountain chalet",
                Amenities = new List<string> { "Hot Tub", "Ski-in/Ski-out", "Fireplace" },
                BookedDates = new List<DateTime> { new DateTime(2023, 12, 25), new DateTime(2023, 12, 31) }
            }
        };

        public static List<PropertyDetails> Properties => properties;
    }
}
