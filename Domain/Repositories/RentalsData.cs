using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public static class RentalsData
    {
        private static List<PropertyListing> properties = new List<PropertyListing>
        {
            new PropertyListing()
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350
            },
            new PropertyListing()
            {
                Id = 2,
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
            },
            new PropertyListing()
            {
                Id = 3,
                Name = "Alpine Retreat",
                Blurb = "Escape to the Alps in this cozy retreat",
                Location = "Swiss Alps",
                NumberOfBedrooms = 3,
                CostPerNight = 400
            },
            new PropertyListing()
            {
                Id = 4,
                Name = "Tropical Paradise House",
                Blurb = "Experience paradise in this tropical getaway",
                Location = "Bora Bora, French Polynesia",
                NumberOfBedrooms = 4,
                CostPerNight = 800
            },
            new PropertyListing()
            {
                Id = 5,
                Name = "Modern City Loft",
                Blurb = "Chic loft in the heart of downtown",
                Location = "New York City, USA",
                NumberOfBedrooms = 1,
                CostPerNight = 350
            },
            new PropertyListing()
            {
                Id = 6,
                Name = "Rustic Mountain Cabin",
                Blurb = "Escape to nature in this rustic cabin",
                Location = "Rocky Mountains, USA",
                NumberOfBedrooms = 2,
                CostPerNight = 300
            },
            new PropertyListing()
            {
                Id = 7,
                Name = "Historic Castle",
                Blurb = "Live like royalty in this historic castle",
                Location = "Edinburgh, Scotland",
                NumberOfBedrooms = 10,
                CostPerNight = 1500
            },
            new PropertyListing()
            {
                Id = 8,
                Name = "Zen Garden Retreat",
                Blurb = "Find peace in this tranquil garden retreat",
                Location = "Kyoto, Japan",
                NumberOfBedrooms = 3,
                CostPerNight = 600
            },
            new PropertyListing()
            {
                Id = 9,
                Name = "Desert Oasis Villa",
                Blurb = "Escape to the desert in this luxurious villa",
                Location = "Scottsdale, Arizona",
                NumberOfBedrooms = 6,
                CostPerNight = 900
            },
            new PropertyListing()
            {
                Id = 10,
                Name = "Snowy Mountain Chalet",
                Blurb = "Cozy chalet with stunning mountain views",
                Location = "Whistler, Canada",
                NumberOfBedrooms = 4,
                CostPerNight = 700
            }
        };
    }
}
        
        