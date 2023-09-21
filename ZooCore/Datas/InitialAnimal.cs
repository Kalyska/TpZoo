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
            new Animal() { Id = 1, Name="Guillaume", Age = 5, Description ="L’’alligator est un grand reptile, c’est même l’un des plus gros crocodilien au monde, pouvant atteindre jusqu’à 4,5 mètres et peser plus de 450 kilos.", ImageUrl = "/images/Alligator.webp", SpeciesId =  1},

            new Animal() { Id = 2, Name="Clemence", Age = 5, Description ="La chauve-souris, aussi appelée « roussette » ou « renard volant », est une espèce du genre des Pteropus, une branche des « mégachiroptères ». Endémique de l’île de Rodrigues, ce mammifère volant atteint une taille et une envergure assez conséquentes : son corps mesure 15 à 20 cm et son envergure est de 50 à 90 cm. Elle pèse généralement entre 300 et 350 grammes.", ImageUrl = "/images/ChauveSouris.webp", SpeciesId =  4 },

            new Animal() { Id = 3, Name="Remy", Age = 10, Description ="Le panda géant vit dans les régions montagneuses de Chine, entre 1 200 et 4 100 mètres d'altitude. Bien qu'il soit classé parmi les mammifères carnivores, il mange presque exclusivement des pousses de bambou.", ImageUrl = "/images/Panda.webp", SpeciesId =  13 },

            new Animal() { Id = 4, Name="Johnny", Age = 17, Description ="De la famille des hominidés, le chimpanzé commun peut vivre jusqu’à 50/60 ans et peser 40 à 65 kg. Lointain cousin des humains, il partage avec nous de nombreuses similarités.", ImageUrl = "/images/Chimpanze.webp", SpeciesId =  3 },

            new Animal() { Id = 5, Name="Gregory", Age = 6, Description ="Pouvant mesurer jusqu’à 3,10 mètres de long et peser jusqu’à 165 kg, le dragon (ou varan) de Komodo est le lézard le plus grand du monde. Très trapu, ce reptile de la famille des varanidés à l’allure imposante est doté d’une cuirasse et d’une queue extrêmement musclée.", ImageUrl = "/images/DragonKomodo.webp", SpeciesId =  14 },

            new Animal() { Id = 6, Name="Kevin", Age = 1, Description ="Le gorille est le plus gros singe semblable à l’Homme au monde. Les mâles peuvent peser jusqu’à 250 kg ! Le mâle adulte présente une stature beaucoup plus imposante que la femelle. Sa tête est beaucoup plus volumineuse et, à l’âge adulte, le dos des mâles se colore de gris.", ImageUrl = "/images/Gorille.webp" , SpeciesId =  7},

            new Animal() { Id = 7, Name="Gaetan", Age = 2, Description ="L'éléphant d'Afrique des savanes peut peser plus de 7 tonnes et mesurer jusqu'à 4 mètres de hauteur. Les seuls animaux pouvant rivaliser avec lui au concours de l’animal le plus lourd sont les cétacés, comme la baleine bleue… Aucun mammifère terrestre n’est à la hauteur.", ImageUrl = "/images/Elephant.webp" , SpeciesId =  5},

            new Animal() { Id = 8, Name="Adrien", Age = 3, Description ="De la famille des Hippopotamidae, ce géant semi-aquatique peut peser jusqu’à 3 tonnes et vivre 40 à 50 ans ! Un nouveau-né pèse environ 50 kg à la naissance.L’hippopotame vit principalement dans les rivières, les lacs ou les fleuves, comme le Nil, à proximité de pâturages où il trouve sa nourriture quand vient le soir.", ImageUrl = "/images/Hippopotame.webp" , SpeciesId =  9},

            new Animal() { Id = 9, Name="Malik", Age = 4, Description ="La girafe est un animal très social, vivant en groupe de 5 à 20 individus dans les savanes africaines. La vie en communauté permet de repérer les prédateurs et se défendre de leurs attaques.", ImageUrl = "/images/Girafe.webp" , SpeciesId =  6},

            new Animal() { Id = 10, Name="Slimane", Age = 9, Description ="Le diable de Tasmanie, mammifère endémique de l’île de Tasmanie au sud de l’Océanie, est aujourd’hui le plus grand marsupial carnivore d’Australie, bien qu’il ne dépasse pas la taille d’un chien. En dépit de son apparence, de son alimentation et de son nom, le diable de Tasmanie est en réalité timide, méfiant et ne s’attaque à l’Homme que s’il se sent menacé.", ImageUrl = "/images/DiableTasmanie.webp" , SpeciesId =  15},

            new Animal() { Id = 11, Name="Anthony", Age = 7, Description ="Le charisme et l’apparence majestueuse du lion lui ont donné le surnom de roi des animaux. Ce grand prédateur veille en véritable monarque sur son territoire et sa cour, composée de lionnes et leurs petits. Ce sont ces femelles qui assurent l’essentiel des chasses et approvisionnent le groupe.", ImageUrl = "/images/Lion.webp" , SpeciesId =  10},

            new Animal() { Id = 12, Name="Thomas", Age = 2, Description ="Souvent confondu avec le toucan à cause de son gigantesque bec, le calao rhinocéros se différencie pourtant par une particularité notable : son casque. Surmontant le bec comme une corne, le casque des calaos varie en taille et en couleur selon l’espèce.", ImageUrl = "/images/Calao.webp" , SpeciesId =  2 },

            new Animal() { Id = 13, Name="Carole", Age = 2, Description ="Souvent confondu avec le toucan à cause de son gigantesque bec, le calao rhinocéros se différencie pourtant par une particularité notable : son casque. Surmontant le bec comme une corne, le casque des calaos varie en taille et en couleur selon l’espèce.", ImageUrl = "/images/Calao.webp" , SpeciesId =  2},

            new Animal() { Id = 14, Name="Nicolas", Age = 7, Description ="L'éléphant d'Afrique des savanes peut peser plus de 7 tonnes et mesurer jusqu'à 4 mètres de hauteur. Les seuls animaux pouvant rivaliser avec lui au concours de l’animal le plus lourd sont les cétacés, comme la baleine bleue… Aucun mammifère terrestre n’est à la hauteur.", ImageUrl = "/images/Elephant.webp" , SpeciesId =  5 },

            new Animal() { Id = 15, Name="Aicha", Age = 1, Description ="La girafe est un animal très social, vivant en groupe de 5 à 20 individus dans les savanes africaines. La vie en communauté permet de repérer les prédateurs et se défendre de leurs attaques.", ImageUrl = "/images/Girafe.webp" , SpeciesId =  6},

        };

    }
}
