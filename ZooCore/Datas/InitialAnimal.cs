using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCore.Models;

namespace ZooCore.Datas
{
    public static class InitialAnimal
    {

        public static readonly List<Animal> Animals = new List<Animal>()
        {
            new Animal() { Id = 1, Name="Guillaume", Age = 5, Description ="L’’alligator est un grand reptile, c’est même l’un des plus gros crocodilien au monde, pouvant atteindre jusqu’à 4,5 mètres et peser plus de 450 kilos.", ImageUrl = "/images/Alligator.webp" },

            new Animal() { Id = 2, Name="Clemence", Age = 5, Description ="La chauve-souris, aussi appelée « roussette » ou « renard volant », est une espèce du genre des Pteropus, une branche des « mégachiroptères ». Endémique de l’île de Rodrigues, ce mammifère volant atteint une taille et une envergure assez conséquentes : son corps mesure 15 à 20 cm et son envergure est de 50 à 90 cm. Elle pèse généralement entre 300 et 350 grammes.", ImageUrl = "/images/ChauveSouris.webp" },

            new Animal() { Id = 3, Name="Remy", Age = 10, Description ="", ImageUrl = "/images/Panda.webp" },

            new Animal() { Id = 4, Name="Johnny", Age = 7, Description ="", ImageUrl = "/images/Chimpanze.webp" },

            new Animal() { Id = 5, Name="Gregory", Age = 6, Description ="", ImageUrl = "/images/DragonKomodo.webp" },

            new Animal() { Id = 6, Name="Kevin", Age = 1, Description ="", ImageUrl = "/images/Gorille.webp" },

            new Animal() { Id = 7, Name="Gaetan", Age = 2, Description ="", ImageUrl = "/images/Elephant.webp" },

            new Animal() { Id = 8, Name="Adrien", Age = 3, Description ="", ImageUrl = "/images/Hippopotame.webp" },

            new Animal() { Id = 9, Name="Malik", Age = 4, Description ="", ImageUrl = "/images/Girafe.webp" },

            new Animal() { Id = 10, Name="Slimane", Age = 9, Description ="", ImageUrl = "/images/DiableTasmanie.webp" },

            new Animal() { Id = 11, Name="Anthony", Age = 7, Description ="", ImageUrl = "/images/Lion.webp" },

            new Animal() { Id = 12, Name="Thomas", Age = 2, Description ="Souvent confondu avec le toucan à cause de son gigantesque bec, le calao rhinocéros se différencie pourtant par une particularité notable : son casque. Surmontant le bec comme une corne, le casque des calaos varie en taille et en couleur selon l’espèce.", ImageUrl = "/images/Calao.webp" },

            new Animal() { Id = 13, Name="Carole", Age = 2, Description ="Souvent confondu avec le toucan à cause de son gigantesque bec, le calao rhinocéros se différencie pourtant par une particularité notable : son casque. Surmontant le bec comme une corne, le casque des calaos varie en taille et en couleur selon l’espèce.", ImageUrl = "/images/Calao.webp" },

            new Animal() { Id = 14, Name="Nicolas", Age = 7, Description ="", ImageUrl = "/images/Elephant.webp" },

            new Animal() { Id = 15, Name="Aicha", Age = 1, Description ="", ImageUrl = "/images/Girafe.webp" },

        };

    }
}
