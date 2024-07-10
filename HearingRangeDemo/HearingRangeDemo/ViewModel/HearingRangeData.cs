using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace HearingRangeDemo
{
    public class HearingRangeData
    {
        public ObservableCollection<HearingRangeModel> Data { get; set; }
        public HearingRangeData()
        {
            Data = new ObservableCollection<HearingRangeModel>()
            {
                new HearingRangeModel("Tuna",50,1100),
                new HearingRangeModel("Chicken", 125,2000),
                new HearingRangeModel("Goldfish", 20, 3000),
                new HearingRangeModel("Bullfrog",100,3000),
                new HearingRangeModel("Catfish",50,4000),
                new HearingRangeModel("Treefrog",50, 4000),
                new HearingRangeModel("Canary",250, 8000),
                new HearingRangeModel("Cockatiel",250,8000),
                new HearingRangeModel("Parakeet",200,8500),
                new HearingRangeModel("Elephant",17,10500),
                new HearingRangeModel("Owl",200,12000),
                new HearingRangeModel("Human",31,19000),
                new HearingRangeModel("Chinchilla",52,33000),
                new HearingRangeModel("Horse",55,33500),
                new HearingRangeModel("Cow",23,35000),
                new HearingRangeModel("Raccoon",100,40000),
                new HearingRangeModel("Sheep",125,42500),
                new HearingRangeModel("Dog",64,44000),
                new HearingRangeModel("Ferret",16,44000),
                new HearingRangeModel("Hedgehog",250,45000),
                new HearingRangeModel("Guinea-pig",47,49000),
                new HearingRangeModel("Rabbit",96,49000),
                new HearingRangeModel("Sealion",200,50000),
                new HearingRangeModel("Gerbil",56,60000),
                new HearingRangeModel("Opossum",500,64000),
                new HearingRangeModel("Albinorat", 390, 72000),
                new HearingRangeModel("Hoodedrat",530,75000),
                new HearingRangeModel("Cat",55,77000),
                new HearingRangeModel("Mouse",900, 79000),
                new HearingRangeModel("Little-brown-bat",10300,115000),
                new HearingRangeModel("Belugawhale",1000,123000),
                new HearingRangeModel("Bottlenosedolphin",150,150000),
                new HearingRangeModel("Porpoise", 75, 150000),
            };
        }
    }
}
