using System;

namespace Living{
  class Animal{

    int numOfLegs;
    string animalType;


    public Animal(){
      this.numOfLegs = 4;
      this.animalType = "Dogs";
    }

    public Animal(int numOfLegs, string animalType){
      this.numOfLegs = numOfLegs;
      this.animalType = animalType;
    }
  }
}