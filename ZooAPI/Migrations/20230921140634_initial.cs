using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Alligator", 1 },
                    { 2, "Calao", 3 },
                    { 3, "Chimpanzé", 4 },
                    { 4, "Chauve-souris", 4 },
                    { 5, "Eléphant d'Afrique", 4 },
                    { 6, "Girafe", 4 },
                    { 7, "Gorille", 5 },
                    { 8, "Guépard", 3 },
                    { 9, "Hippopotame", 3 },
                    { 10, "Lion", 3 },
                    { 13, "Panda", 3 },
                    { 14, "Dragon de Komodo", 4 },
                    { 15, "Diable de Tasmanie", 4 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Description", "ImageUrl", "Name", "SpeciesId" },
                values: new object[,]
                {
                    { 1, 5, "L’’alligator est un grand reptile, c’est même l’un des plus gros crocodilien au monde, pouvant atteindre jusqu’à 4,5 mètres et peser plus de 450 kilos.", "/images/Alligator.webp", "Guillaume", 1 },
                    { 2, 5, "La chauve-souris, aussi appelée « roussette » ou « renard volant », est une espèce du genre des Pteropus, une branche des « mégachiroptères ». Endémique de l’île de Rodrigues, ce mammifère volant atteint une taille et une envergure assez conséquentes : son corps mesure 15 à 20 cm et son envergure est de 50 à 90 cm. Elle pèse généralement entre 300 et 350 grammes.", "/images/ChauveSouris.webp", "Clemence", 4 },
                    { 3, 10, "Le panda géant vit dans les régions montagneuses de Chine, entre 1 200 et 4 100 mètres d'altitude. Bien qu'il soit classé parmi les mammifères carnivores, il mange presque exclusivement des pousses de bambou.", "/images/Panda.webp", "Remy", 13 },
                    { 4, 17, "De la famille des hominidés, le chimpanzé commun peut vivre jusqu’à 50/60 ans et peser 40 à 65 kg. Lointain cousin des humains, il partage avec nous de nombreuses similarités.", "/images/Chimpanze.webp", "Johnny", 3 },
                    { 5, 6, "Pouvant mesurer jusqu’à 3,10 mètres de long et peser jusqu’à 165 kg, le dragon (ou varan) de Komodo est le lézard le plus grand du monde. Très trapu, ce reptile de la famille des varanidés à l’allure imposante est doté d’une cuirasse et d’une queue extrêmement musclée.", "/images/DragonKomodo.webp", "Gregory", 14 },
                    { 6, 1, "Le gorille est le plus gros singe semblable à l’Homme au monde. Les mâles peuvent peser jusqu’à 250 kg ! Le mâle adulte présente une stature beaucoup plus imposante que la femelle. Sa tête est beaucoup plus volumineuse et, à l’âge adulte, le dos des mâles se colore de gris.", "/images/Gorille.webp", "Kevin", 7 },
                    { 7, 2, "L'éléphant d'Afrique des savanes peut peser plus de 7 tonnes et mesurer jusqu'à 4 mètres de hauteur. Les seuls animaux pouvant rivaliser avec lui au concours de l’animal le plus lourd sont les cétacés, comme la baleine bleue… Aucun mammifère terrestre n’est à la hauteur.", "/images/Elephant.webp", "Gaetan", 5 },
                    { 8, 3, "De la famille des Hippopotamidae, ce géant semi-aquatique peut peser jusqu’à 3 tonnes et vivre 40 à 50 ans ! Un nouveau-né pèse environ 50 kg à la naissance.L’hippopotame vit principalement dans les rivières, les lacs ou les fleuves, comme le Nil, à proximité de pâturages où il trouve sa nourriture quand vient le soir.", "/images/Hippopotame.webp", "Adrien", 9 },
                    { 9, 4, "La girafe est un animal très social, vivant en groupe de 5 à 20 individus dans les savanes africaines. La vie en communauté permet de repérer les prédateurs et se défendre de leurs attaques.", "/images/Girafe.webp", "Malik", 6 },
                    { 10, 9, "Le diable de Tasmanie, mammifère endémique de l’île de Tasmanie au sud de l’Océanie, est aujourd’hui le plus grand marsupial carnivore d’Australie, bien qu’il ne dépasse pas la taille d’un chien. En dépit de son apparence, de son alimentation et de son nom, le diable de Tasmanie est en réalité timide, méfiant et ne s’attaque à l’Homme que s’il se sent menacé.", "/images/DiableTasmanie.webp", "Slimane", 15 },
                    { 11, 7, "Le charisme et l’apparence majestueuse du lion lui ont donné le surnom de roi des animaux. Ce grand prédateur veille en véritable monarque sur son territoire et sa cour, composée de lionnes et leurs petits. Ce sont ces femelles qui assurent l’essentiel des chasses et approvisionnent le groupe.", "/images/Lion.webp", "Anthony", 10 },
                    { 12, 2, "Souvent confondu avec le toucan à cause de son gigantesque bec, le calao rhinocéros se différencie pourtant par une particularité notable : son casque. Surmontant le bec comme une corne, le casque des calaos varie en taille et en couleur selon l’espèce.", "/images/Calao.webp", "Thomas", 2 },
                    { 13, 2, "Souvent confondu avec le toucan à cause de son gigantesque bec, le calao rhinocéros se différencie pourtant par une particularité notable : son casque. Surmontant le bec comme une corne, le casque des calaos varie en taille et en couleur selon l’espèce.", "/images/Calao.webp", "Carole", 2 },
                    { 14, 7, "L'éléphant d'Afrique des savanes peut peser plus de 7 tonnes et mesurer jusqu'à 4 mètres de hauteur. Les seuls animaux pouvant rivaliser avec lui au concours de l’animal le plus lourd sont les cétacés, comme la baleine bleue… Aucun mammifère terrestre n’est à la hauteur.", "/images/Elephant.webp", "Nicolas", 5 },
                    { 15, 1, "La girafe est un animal très social, vivant en groupe de 5 à 20 individus dans les savanes africaines. La vie en communauté permet de repérer les prédateurs et se défendre de leurs attaques.", "/images/Girafe.webp", "Aicha", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_SpeciesId",
                table: "Animals",
                column: "SpeciesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
