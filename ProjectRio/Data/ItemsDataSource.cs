using System;
using System.Collections.Generic;

namespace ProjectRio.Data
{
    public class ItemsDataSource
    {
        static string DF = "Distrito Federal";
        static string GO = "Goiás";
        static string MG = "Minas Gerais";
        static string RJ = "Rio de Janeiro";
        static string ES = "Espírito Santo";
        static string BA = "Bahia";
        static string PE = "Pernambuco";
        static string SE = "Sergipe";
        static string AL = "Alagoas";
        static string PB = "Paraíba";
        static string RN = "Rio Grande do Norte";
        static string CE = "Ceará";
        static string PI = "Piauí";
        static string TO = "Tocantins";
        static string MA = "Maranhão";
        static string PA = "Pará";
        static string AP = "Amapá";
        static string RR = "Roraima";
        static string AM = "Amazonas";
        static string AC = "Acre";
        static string MT = "Mato Grosso";
        static string MS = "Mato Grosso do Sul";
        static string SP = "São Paulo";
        static string PR = "Paraná";
        static string SC = "Santa Catarina";
        static string RS = "Rio Grande do Sul";
        static string RO = "Rondônia";

        private static List<Item> _items = new List<Item>()
        {
            new Item()
            {
                Id = 0,
                DateOfVisit = Convert.ToDateTime("05/03/2016"),
                CityName = "Brasília",
                State = DF,
                Description = "vamos lá",
            },
            new Item()
            {
                Id = 1,
                DateOfVisit = Convert.ToDateTime("05/04/2016"),
                CityName = "Corumbá de Goiás",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 2,
                DateOfVisit = Convert.ToDateTime("05/04/2016"),
                CityName = "Pirenópolis",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 3,
                DateOfVisit = Convert.ToDateTime("05/04/2016"),
                CityName = "Anápolis",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 4,
                DateOfVisit = Convert.ToDateTime("05/05/2016"),
                CityName = "Itaberaí",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 5,
                DateOfVisit = Convert.ToDateTime("05/05/2016"),
                CityName = "Cidade de Goiás",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 6,
                DateOfVisit = Convert.ToDateTime("05/05/2016"),
                CityName = "Inhumas",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 6,
                DateOfVisit = Convert.ToDateTime("05/05/2016"),
                CityName = "Goiânia",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 7,
                DateOfVisit = Convert.ToDateTime("05/06/2016"),
                CityName = "Trindade",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 8,
                DateOfVisit = Convert.ToDateTime("05/06/2016"),
                CityName = "Aparecida de Goiânia",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 9,
                DateOfVisit = Convert.ToDateTime("05/06/2016"),
                CityName = "Piracanjuba",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 10,
                DateOfVisit = Convert.ToDateTime("05/06/2016"),
                CityName = "Morrinhos",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 11,
                DateOfVisit = Convert.ToDateTime("05/06/2016"),
                CityName = "Caldas Novas",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 12,
                DateOfVisit = Convert.ToDateTime("05/07/2016"),
                CityName = "Pires do Rio",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 13,
                DateOfVisit = Convert.ToDateTime("05/07/2016"),
                CityName = "Ipameri",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 14,
                DateOfVisit = Convert.ToDateTime("05/07/2016"),
                CityName = "Goiandira",
                State = GO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 15,
                DateOfVisit = Convert.ToDateTime("05/07/2016"),
                CityName = "Araguari",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 16,
                DateOfVisit = Convert.ToDateTime("05/07/2016"),
                CityName = "Uberlândia",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 17,
                DateOfVisit = Convert.ToDateTime("05/08/2016"),
                CityName = "Uberaba",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 18,
                DateOfVisit = Convert.ToDateTime("05/08/2016"),
                CityName = "Araxá",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 19,
                DateOfVisit = Convert.ToDateTime("05/08/2016"),
                CityName = "Serra do Salitre",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 20,
                DateOfVisit = Convert.ToDateTime("05/08/2016"),
                CityName = "Patrocínio",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 21,
                DateOfVisit = Convert.ToDateTime("05/08/2016"),
                CityName = "Patos de Minas",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 22,
                DateOfVisit = Convert.ToDateTime("05/09/2016"),
                CityName = "Varjão de Minas",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 23,
                DateOfVisit = Convert.ToDateTime("05/09/2016"),
                CityName = "Pirapora",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 24,
                DateOfVisit = Convert.ToDateTime("05/09/2016"),
                CityName = "Montes Claros",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 25,
                DateOfVisit = Convert.ToDateTime("05/10/2016"),
                CityName = "Bocaiúva",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 26,
                DateOfVisit = Convert.ToDateTime("05/10/2016"),
                CityName = "Couto de Magalhães de Minas",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 27,
                DateOfVisit = Convert.ToDateTime("05/10/2016"),
                CityName = "Diamantina",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 28,
                DateOfVisit = Convert.ToDateTime("05/10/2016"),
                CityName = "Curvelo",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 29,
                DateOfVisit = Convert.ToDateTime("05/11/2016"),
                CityName = "Gouveia",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 30,
                DateOfVisit = Convert.ToDateTime("05/11/2016"),
                CityName = "Datas",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 31,
                DateOfVisit = Convert.ToDateTime("05/11/2016"),
                CityName = "Serro",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 32,
                DateOfVisit = Convert.ToDateTime("05/11/2016"),
                CityName = "Guanhães",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 33,
                DateOfVisit = Convert.ToDateTime("05/11/2016"),
                CityName = "Governador Valadares",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 34,
                DateOfVisit = Convert.ToDateTime("05/12/2016"),
                CityName = "Naque",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 35,
                DateOfVisit = Convert.ToDateTime("05/12/2016"),
                CityName = "Ipatinga",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 36,
                DateOfVisit = Convert.ToDateTime("05/12/2016"),
                CityName = "Coronel Fabriciano",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 37,
                DateOfVisit = Convert.ToDateTime("05/12/2016"),
                CityName = "Itabira",
                State = MG,
                Description = "App secreto, dia 01/03",
            },

            new Item()
            {
                Id = 38,
                DateOfVisit = Convert.ToDateTime("05/13/2016"),
                CityName = "Outro Preto",
                State = MG,
                Description = "App secreto, dia 01/03",
            },

            new Item()
            {
                Id = 39,
                DateOfVisit = Convert.ToDateTime("05/13/2016"),
                CityName = "Itabirito",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 40,
                DateOfVisit = Convert.ToDateTime("05/14/2016"),
                CityName = "Betim",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 41,
                DateOfVisit = Convert.ToDateTime("05/14/2016"),
                CityName = "Contagem",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 42,
                DateOfVisit = Convert.ToDateTime("05/14/2016"),
                CityName = "Belo Horizonte",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 43,
                DateOfVisit = Convert.ToDateTime("05/15/2016"),
                CityName = "São João Del Rei",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 44,
                DateOfVisit = Convert.ToDateTime("05/15/2016"),
                CityName = "Tiradentes",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 45,
                DateOfVisit = Convert.ToDateTime("05/15/2016"),
                CityName = "Barbacena",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 46,
                DateOfVisit = Convert.ToDateTime("05/15/2016"),
                CityName = "Juiz de Fora",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 47,
                DateOfVisit = Convert.ToDateTime("05/16/2016"),
                CityName = "Bicas",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 48,
                DateOfVisit = Convert.ToDateTime("05/16/2016"),
                CityName = "Leopoldina",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 49,
                DateOfVisit = Convert.ToDateTime("05/16/2016"),
                CityName = "Muriaé",
                State = MG,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 50,
                DateOfVisit = Convert.ToDateTime("05/16/2016"),
                CityName = "Itaperuna",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 51,
                DateOfVisit = Convert.ToDateTime("05/16/2016"),
                CityName = "Bom Jesus do Itabapoana",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 52,
                DateOfVisit = Convert.ToDateTime("05/16/2016"),
                CityName = "Cachoeiro de Itapemirim",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 53,
                DateOfVisit = Convert.ToDateTime("05/17/2016"),
                CityName = "Guarapari",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 54,
                DateOfVisit = Convert.ToDateTime("05/17/2016"),
                CityName = "Vila Velha",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 55,
                DateOfVisit = Convert.ToDateTime("05/17/2016"),
                CityName = "Vitória",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 56,
                DateOfVisit = Convert.ToDateTime("05/18/2016"),
                CityName = "Serra",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 57,
                DateOfVisit = Convert.ToDateTime("05/18/2016"),
                CityName = "Aracruz",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 58,
                DateOfVisit = Convert.ToDateTime("05/18/2016"),
                CityName = "Colatina",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 59,
                DateOfVisit = Convert.ToDateTime("05/18/2016"),
                CityName = "Linhares",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 60,
                DateOfVisit = Convert.ToDateTime("05/18/2016"),
                CityName = "São Mateus",
                State = ES,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 61,
                DateOfVisit = Convert.ToDateTime("05/19/2016"),
                CityName = "Teixeira de Freitas",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 62,
                DateOfVisit = Convert.ToDateTime("05/19/2016"),
                CityName = "Itamaraju",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 63,
                DateOfVisit = Convert.ToDateTime("05/19/2016"),
                CityName = "Santa Cruz Cabrália",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 64,
                DateOfVisit = Convert.ToDateTime("05/19/2016"),
                CityName = "Porto seguro",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 65,
                DateOfVisit = Convert.ToDateTime("05/20/2016"),
                CityName = "Eunápolis",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 66,
                DateOfVisit = Convert.ToDateTime("05/20/2016"),
                CityName = "Itapetinga",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 67,
                DateOfVisit = Convert.ToDateTime("05/20/2016"),
                CityName = "Vitária da Conquista",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 68,
                DateOfVisit = Convert.ToDateTime("05/21/2016"),
                CityName = "Itambé",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 69,
                DateOfVisit = Convert.ToDateTime("05/21/2016"),
                CityName = "Floresta Azul",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 70,
                DateOfVisit = Convert.ToDateTime("05/21/2016"),
                CityName = "Ibicaraí",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 71,
                DateOfVisit = Convert.ToDateTime("05/21/2016"),
                CityName = "Itabuna",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 72,
                DateOfVisit = Convert.ToDateTime("05/21/2016"),
                CityName = "Ilhéus",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 73,
                DateOfVisit = Convert.ToDateTime("05/22/2016"),
                CityName = "Itacaré",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 74,
                DateOfVisit = Convert.ToDateTime("05/22/2016"),
                CityName = "Camamu",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 75,
                DateOfVisit = Convert.ToDateTime("05/22/2016"),
                CityName = "Ituberá",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 76,
                DateOfVisit = Convert.ToDateTime("05/22/2016"),
                CityName = "Cairu",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 77,
                DateOfVisit = Convert.ToDateTime("05/22/2016"),
                CityName = "Valença",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 78,
                DateOfVisit = Convert.ToDateTime("05/23/2016"),
                CityName = "Lençóis",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 79,
                DateOfVisit = Convert.ToDateTime("05/24/2016"),
                CityName = "Salvador",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 80,
                DateOfVisit = Convert.ToDateTime("05/25/2016"),
                CityName = "Feira de Santana",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 81,
                DateOfVisit = Convert.ToDateTime("05/25/2016"),
                CityName = "Riachão do Jacuípe",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 82,
                DateOfVisit = Convert.ToDateTime("05/25/2016"),
                CityName = "Capim Grosso",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 83,
                DateOfVisit = Convert.ToDateTime("05/25/2016"),
                CityName = "Senhor do Bonfim",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 84,
                DateOfVisit = Convert.ToDateTime("05/26/2016"),
                CityName = "Jaguarani",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 85,
                DateOfVisit = Convert.ToDateTime("05/26/2016"),
                CityName = "Juazeiro",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 86,
                DateOfVisit = Convert.ToDateTime("05/26/2016"),
                CityName = "Sobradinho",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 87,
                DateOfVisit = Convert.ToDateTime("05/26/2016"),
                CityName = "Petrolina",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 88,
                DateOfVisit = Convert.ToDateTime("05/27/2016"),
                CityName = "Lagoa Grande",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 89,
                DateOfVisit = Convert.ToDateTime("05/27/2016"),
                CityName = "Santa Maria da Boa Vista",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 90,
                DateOfVisit = Convert.ToDateTime("05/27/2016"),
                CityName = "Orocó",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 91,
                DateOfVisit = Convert.ToDateTime("05/27/2016"),
                CityName = "Cabrobó",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 92,
                DateOfVisit = Convert.ToDateTime("05/27/2016"),
                CityName = "Paulo Afonso",
                State = BA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 93,
                DateOfVisit = Convert.ToDateTime("05/28/2016"),
                CityName = "Canidé de São Francisco",
                State = SE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 94,
                DateOfVisit = Convert.ToDateTime("05/28/2016"),
                CityName = "Poço Redondo",
                State = SE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 95,
                DateOfVisit = Convert.ToDateTime("05/28/2016"),
                CityName = "Nossa Senhora da Glória",
                State = SE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 96,
                DateOfVisit = Convert.ToDateTime("05/28/2016"),
                CityName = "Nossa Senhora das Dores",
                State = SE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 97,
                DateOfVisit = Convert.ToDateTime("05/28/2016"),
                CityName = "Aracaju",
                State = SE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 98,
                DateOfVisit = Convert.ToDateTime("05/29/2016"),
                CityName = "Propriá",
                State = SE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 99,
                DateOfVisit = Convert.ToDateTime("05/29/2016"),
                CityName = "São Sebastião",
                State = AL,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 100,
                DateOfVisit = Convert.ToDateTime("05/29/2016"),
                CityName = "Arapiraca",
                State = AL,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 101,
                DateOfVisit = Convert.ToDateTime("05/29/2016"),
                CityName = "São Miguel dos Campos",
                State = AL,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 102,
                DateOfVisit = Convert.ToDateTime("05/29/2016"),
                CityName = "Maceió",
                State = AL,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 103,
                DateOfVisit = Convert.ToDateTime("05/30/2016"),
                CityName = "Murici",
                State = AL,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 104,
                DateOfVisit = Convert.ToDateTime("05/30/2016"),
                CityName = "União dos Palmares",
                State = AL,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 105,
                DateOfVisit = Convert.ToDateTime("05/30/2016"),
                CityName = "Garanhuns",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 106,
                DateOfVisit = Convert.ToDateTime("05/30/2016"),
                CityName = "Lajedo",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 107,
                DateOfVisit = Convert.ToDateTime("05/30/2016"),
                CityName = "Caruaru",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 108,
                DateOfVisit = Convert.ToDateTime("05/31/2016"),
                CityName = "Gravatá",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 109,
                DateOfVisit = Convert.ToDateTime("05/31/2016"),
                CityName = "Jaboatão dos Guararapes",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 110,
                DateOfVisit = Convert.ToDateTime("05/31/2016"),
                CityName = "Recife",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 111,
                DateOfVisit = Convert.ToDateTime("06/01/2016"),
                CityName = "Ipojuca",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 112,
                DateOfVisit = Convert.ToDateTime("06/02/2016"),
                CityName = "Olinda",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 113,
                DateOfVisit = Convert.ToDateTime("06/02/2016"),
                CityName = "Igarassu",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 114,
                DateOfVisit = Convert.ToDateTime("06/02/2016"),
                CityName = "Goiana",
                State = PE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 115,
                DateOfVisit = Convert.ToDateTime("06/02/2016"),
                CityName = "Pedras de fogo",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 116,
                DateOfVisit = Convert.ToDateTime("06/02/2016"),
                CityName = "Itabaiana",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 117,
                DateOfVisit = Convert.ToDateTime("06/02/2016"),
                CityName = "Campina Grande",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 118,
                DateOfVisit = Convert.ToDateTime("06/03/2016"),
                CityName = "Guarabira",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 119,
                DateOfVisit = Convert.ToDateTime("06/03/2016"),
                CityName = "Sapé",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 120,
                DateOfVisit = Convert.ToDateTime("06/03/2016"),
                CityName = "João Pessoa",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 121,
                DateOfVisit = Convert.ToDateTime("06/04/2016"),
                CityName = "Mamanguape",
                State = PB,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 122,
                DateOfVisit = Convert.ToDateTime("06/04/2016"),
                CityName = "São José de Mipibu",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 123,
                DateOfVisit = Convert.ToDateTime("06/04/2016"),
                CityName = "Parnamirim",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 124,
                DateOfVisit = Convert.ToDateTime("06/04/2016"),
                CityName = "Natal",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 125,
                DateOfVisit = Convert.ToDateTime("06/06/2016"),
                CityName = "Lajes",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 126,
                DateOfVisit = Convert.ToDateTime("06/06/2016"),
                CityName = "Angicos",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 127,
                DateOfVisit = Convert.ToDateTime("06/06/2016"),
                CityName = "Assu",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 128,
                DateOfVisit = Convert.ToDateTime("06/06/2016"),
                CityName = "Mossoró",
                State = RN,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 129,
                DateOfVisit = Convert.ToDateTime("06/07/2016"),
                CityName = "Aracati",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 130,
                DateOfVisit = Convert.ToDateTime("06/07/2016"),
                CityName = "Aquiraz",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 131,
                DateOfVisit = Convert.ToDateTime("06/07/2016"),
                CityName = "Fortaleza",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 132,
                DateOfVisit = Convert.ToDateTime("06/08/2016"),
                CityName = "Caucaia",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 134,
                DateOfVisit = Convert.ToDateTime("06/08/2016"),
                CityName = "Itapajé",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 135,
                DateOfVisit = Convert.ToDateTime("06/08/2016"),
                CityName = "Irauçuba",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 136,
                DateOfVisit = Convert.ToDateTime("06/08/2016"),
                CityName = "Forquilha",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 137,
                DateOfVisit = Convert.ToDateTime("06/08/2016"),
                CityName = "Sobral",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 138,
                DateOfVisit = Convert.ToDateTime("06/09/2016"),
                CityName = "Massapê",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 139,
                DateOfVisit = Convert.ToDateTime("06/09/2016"),
                CityName = "Granja",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 140,
                DateOfVisit = Convert.ToDateTime("06/09/2016"),
                CityName = "Camocim",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 141,
                DateOfVisit = Convert.ToDateTime("06/09/2016"),
                CityName = "Barroquinha",
                State = CE,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 142,
                DateOfVisit = Convert.ToDateTime("06/09/2016"),
                CityName = "Parnaíba",
                State =PI,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 143,
                DateOfVisit = Convert.ToDateTime("06/10/2016"),
                CityName = "Piracuruca",
                State = PI,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 144,
                DateOfVisit = Convert.ToDateTime("06/10/2016"),
                CityName = "Piriri",
                State = PI,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 145,
                DateOfVisit = Convert.ToDateTime("06/10/2016"),
                CityName = "Campo Maior",
                State = PI,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 146,
                DateOfVisit = Convert.ToDateTime("06/10/2016"),
                CityName = "Altos",
                State = PI,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 147,
                DateOfVisit = Convert.ToDateTime("06/10/2016"),
                CityName = "Teresina",
                State = PI,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 148,
                DateOfVisit = Convert.ToDateTime("06/11/2016"),
                CityName = "Palmas",
                State = TO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 149,
                DateOfVisit = Convert.ToDateTime("06/12/2016"),
                CityName = "São Luís",
                State = MA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 150,
                DateOfVisit = Convert.ToDateTime("06/13/2016"),
                CityName = "Barreirinhas",
                State = MA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 151,
                DateOfVisit = Convert.ToDateTime("06/14/2016"),
                CityName = "Imperatriz",
                State = MA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 152,
                DateOfVisit = Convert.ToDateTime("06/15/2016"),
                CityName = "Belém",
                State = PA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 153,
                DateOfVisit = Convert.ToDateTime("06/16/2016"),
                CityName = "Macapá",
                State = AP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 154,
                DateOfVisit = Convert.ToDateTime("06/17/2016"),
                CityName = "Santarém",
                State = PA,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 155,
                DateOfVisit = Convert.ToDateTime("06/18/2016"),
                CityName = "Boa Vista",
                State = RR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 156,
                DateOfVisit = Convert.ToDateTime("06/19/2016"),
                CityName = "Manaus",
                State = AM,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 157,
                DateOfVisit = Convert.ToDateTime("06/20/2016"),
                CityName = "Iranduba",
                State = AM,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 158,
                DateOfVisit = Convert.ToDateTime("06/20/2016"),
                CityName = "Presidente Figueiredo",
                State = AM,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 159,
                DateOfVisit = Convert.ToDateTime("06/21/2016"),
                CityName = "Rio Branco",
                State = AC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 160,
                DateOfVisit = Convert.ToDateTime("06/22/2016"),
                CityName = "Porto Velho",
                State = RO,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 161,
                DateOfVisit = Convert.ToDateTime("06/23/2016"),
                CityName = "Várzea Grande",
                State = MT,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 162,
                DateOfVisit = Convert.ToDateTime("06/23/2016"),
                CityName = "Cuiabá",
                State = MT,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 163,
                DateOfVisit = Convert.ToDateTime("06/25/2016"),
                CityName = "Campo Grande",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 164,
                DateOfVisit = Convert.ToDateTime("06/26/2016"),
                CityName = "Sidrolândia",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 165,
                DateOfVisit = Convert.ToDateTime("06/26/2016"),
                CityName = "Maracaju",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 166,
                DateOfVisit = Convert.ToDateTime("06/26/2016"),
                CityName = "Rio Brilhante",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 167,
                DateOfVisit = Convert.ToDateTime("06/26/2016"),
                CityName = "Itaporã",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 168,
                DateOfVisit = Convert.ToDateTime("06/26/2016"),
                CityName = "Dourados",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 169,
                DateOfVisit = Convert.ToDateTime("06/27/2016"),
                CityName = "Nova Andradina",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 170,
                DateOfVisit = Convert.ToDateTime("06/27/2016"),
                CityName = "Bataguassu",
                State = MS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 171,
                DateOfVisit = Convert.ToDateTime("06/27/2016"),
                CityName = "Presidente Prudente",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 172,
                DateOfVisit = Convert.ToDateTime("06/28/2016"),
                CityName = "Paraguaçu Paulista",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 173,
                DateOfVisit = Convert.ToDateTime("06/28/2016"),
                CityName = "Marília",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 174,
                DateOfVisit = Convert.ToDateTime("06/28/2016"),
                CityName = "Assis",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 175,
                DateOfVisit = Convert.ToDateTime("06/28/2016"),
                CityName = "Londrina",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 176,
                DateOfVisit = Convert.ToDateTime("06/29/2016"),
                CityName = "Arapongas",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 177,
                DateOfVisit = Convert.ToDateTime("06/29/2016"),
                CityName = "Maringá",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 178,
                DateOfVisit = Convert.ToDateTime("06/29/2016"),
                CityName = "Campo Mourão",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 179,
                DateOfVisit = Convert.ToDateTime("06/29/2016"),
                CityName = "Cascavel",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 180,
                DateOfVisit = Convert.ToDateTime("06/30/2016"),
                CityName = "Matelândia",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 181,
                DateOfVisit = Convert.ToDateTime("06/30/2016"),
                CityName = "Medianeira",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 182,
                DateOfVisit = Convert.ToDateTime("06/30/2016"),
                CityName = "São Miguel do Iguaçu",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 183,
                DateOfVisit = Convert.ToDateTime("06/30/2016"),
                CityName = "Santa Terezinha de Itaipu",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 184,
                DateOfVisit = Convert.ToDateTime("06/30/2016"),
                CityName = "Foz do Iguaçu",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 185,
                DateOfVisit = Convert.ToDateTime("07/02/2016"),
                CityName = "Céu Azul",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 186,
                DateOfVisit = Convert.ToDateTime("07/02/2016"),
                CityName = "Santa Tereza do Oeste",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 187,
                DateOfVisit = Convert.ToDateTime("07/02/2016"),
                CityName = "Realeza",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 188,
                DateOfVisit = Convert.ToDateTime("07/02/2016"),
                CityName = "Francisco Beltrão",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 189,
                DateOfVisit = Convert.ToDateTime("07/02/2016"),
                CityName = "Pato Branco",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 190,
                DateOfVisit = Convert.ToDateTime("07/03/2016"),
                CityName = "São Lourenço do Oeste",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 191,
                DateOfVisit = Convert.ToDateTime("07/03/2016"),
                CityName = "Chapecó",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 192,
                DateOfVisit = Convert.ToDateTime("07/03/2016"),
                CityName = "Concórdia",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 193,
                DateOfVisit = Convert.ToDateTime("07/03/2016"),
                CityName = "Erechim",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 194,
                DateOfVisit = Convert.ToDateTime("07/03/2016"),
                CityName = "Passo Fundo",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 195,
                DateOfVisit = Convert.ToDateTime("07/04/2016"),
                CityName = "São Miguel das Missões",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 196,
                DateOfVisit = Convert.ToDateTime("07/04/2016"),
                CityName = "Santo Ângelo",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 197,
                DateOfVisit = Convert.ToDateTime("07/04/2016"),
                CityName = "Ijuí",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 198,
                DateOfVisit = Convert.ToDateTime("07/04/2016"),
                CityName = "Cruz Alta",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 199,
                DateOfVisit = Convert.ToDateTime("07/05/2016"),
                CityName = "Encantado",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 200,
                DateOfVisit = Convert.ToDateTime("07/05/2016"),
                CityName = "Lajeado",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 201,
                DateOfVisit = Convert.ToDateTime("07/05/2016"),
                CityName = "Santa Cruz do Sul",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 202,
                DateOfVisit = Convert.ToDateTime("07/05/2016"),
                CityName = "Santa Maria",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 203,
                DateOfVisit = Convert.ToDateTime("07/06/2016"),
                CityName = "São Sepé",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 204,
                DateOfVisit = Convert.ToDateTime("07/06/2016"),
                CityName = "Caçapava do Sul",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 205,
                DateOfVisit = Convert.ToDateTime("07/06/2016"),
                CityName = "Canguçu",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 206,
                DateOfVisit = Convert.ToDateTime("07/06/2016"),
                CityName = "Rio Grande",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 207,
                DateOfVisit = Convert.ToDateTime("07/06/2016"),
                CityName = "Petolas",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 208,
                DateOfVisit = Convert.ToDateTime("07/07/2016"),
                CityName = "São Lourenço do Sul",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 209,
                DateOfVisit = Convert.ToDateTime("07/07/2016"),
                CityName = "Camaquã",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 210,
                DateOfVisit = Convert.ToDateTime("07/07/2016"),
                CityName = "Guaíba",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 211,
                DateOfVisit = Convert.ToDateTime("07/07/2016"),
                CityName = "Porto Alegre",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 212,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Canoas",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 214,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Esteio",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 215,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Novo Hamburgo",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 216,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Gramado",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 217,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Canela",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 218,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Nova Petrópolis",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 219,
                DateOfVisit = Convert.ToDateTime("07/08/2016"),
                CityName = "Caxias do Sul",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 220,
                DateOfVisit = Convert.ToDateTime("07/09/2016"),
                CityName = "Bento Gonçalves",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 221,
                DateOfVisit = Convert.ToDateTime("07/09/2016"),
                CityName = "Torres",
                State = RS,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 222,
                DateOfVisit = Convert.ToDateTime("07/09/2016"),
                CityName = "Sombrio",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 223,
                DateOfVisit = Convert.ToDateTime("07/09/2016"),
                CityName = "Araranguá",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 224,
                DateOfVisit = Convert.ToDateTime("07/09/2016"),
                CityName = "Criciúma",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 225,
                DateOfVisit = Convert.ToDateTime("07/10/2016"),
                CityName = "Tubarão",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 226,
                DateOfVisit = Convert.ToDateTime("07/10/2016"),
                CityName = "Laguna",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 227,
                DateOfVisit = Convert.ToDateTime("07/10/2016"),
                CityName = "Palhoça",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 228,
                DateOfVisit = Convert.ToDateTime("07/10/2016"),
                CityName = "São José",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 229,
                DateOfVisit = Convert.ToDateTime("07/10/2016"),
                CityName = "Florianópolis",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 231,
                DateOfVisit = Convert.ToDateTime("07/12/2016"),
                CityName = "Biguaçu",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 232,
                DateOfVisit = Convert.ToDateTime("07/12/2016"),
                CityName = "Balneário Camboriú",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 233,
                DateOfVisit = Convert.ToDateTime("07/12/2016"),
                CityName = "Itajaí",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 234,
                DateOfVisit = Convert.ToDateTime("07/12/2016"),
                CityName = "Ilhota",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 235,
                DateOfVisit = Convert.ToDateTime("07/12/2016"),
                CityName = "Gaspar",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 236,
                DateOfVisit = Convert.ToDateTime("07/12/2016"),
                CityName = "Blumenau",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 237,
                DateOfVisit = Convert.ToDateTime("07/13/2016"),
                CityName = "Massaranduba",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 238,
                DateOfVisit = Convert.ToDateTime("07/13/2016"),
                CityName = "Jaraguá do Sul",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 239,
                DateOfVisit = Convert.ToDateTime("07/13/2016"),
                CityName = "São Francisco do Sul",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 240,
                DateOfVisit = Convert.ToDateTime("07/13/2016"),
                CityName = "Joinville",
                State = SC,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 241,
                DateOfVisit = Convert.ToDateTime("07/14/2016"),
                CityName = "São José dos Pinhais",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 242,
                DateOfVisit = Convert.ToDateTime("07/14/2016"),
                CityName = "Curitiba",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 243,
                DateOfVisit = Convert.ToDateTime("07/15/2016"),
                CityName = "Fazenda Rio Grande",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 244,
                DateOfVisit = Convert.ToDateTime("07/15/2016"),
                CityName = "Araucária",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 245,
                DateOfVisit = Convert.ToDateTime("07/15/2016"),
                CityName = "Campo Largo",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 246,
                DateOfVisit = Convert.ToDateTime("07/15/2016"),
                CityName = "Ponta Grossa",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 247,
                DateOfVisit = Convert.ToDateTime("07/16/2016"),
                CityName = "Castro",
                State = PR,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 248,
                DateOfVisit = Convert.ToDateTime("07/16/2016"),
                CityName = "Itararé",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 249,
                DateOfVisit = Convert.ToDateTime("07/16/2016"),
                CityName = "Itapeva",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 250,
                DateOfVisit = Convert.ToDateTime("07/16/2016"),
                CityName = "Capão Bonito",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 251,
                DateOfVisit = Convert.ToDateTime("07/16/2016"),
                CityName = "Itapetininga",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 252,
                DateOfVisit = Convert.ToDateTime("07/17/2016"),
                CityName = "Sorocaba",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 253,
                DateOfVisit = Convert.ToDateTime("07/17/2016"),
                CityName = "Tatuí",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 254,
                DateOfVisit = Convert.ToDateTime("07/17/2016"),
                CityName = "Botucatu",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 255,
                DateOfVisit = Convert.ToDateTime("07/17/2016"),
                CityName = "Lençóis Paulista",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 256,
                DateOfVisit = Convert.ToDateTime("07/17/2016"),
                CityName = "Bauru",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 257,
                DateOfVisit = Convert.ToDateTime("07/18/2016"),
                CityName = "Jaú",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 258,
                DateOfVisit = Convert.ToDateTime("07/18/2016"),
                CityName = "Araraquapara",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 259,
                DateOfVisit = Convert.ToDateTime("07/18/2016"),
                CityName = "São Carlos",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 260,
                DateOfVisit = Convert.ToDateTime("07/18/2016"),
                CityName = "Riberirão Preto",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 261,
                DateOfVisit = Convert.ToDateTime("07/19/2016"),
                CityName = "Sertãozinho",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 262,
                DateOfVisit = Convert.ToDateTime("07/19/2016"),
                CityName = "Jaboticabal",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 263,
                DateOfVisit = Convert.ToDateTime("07/19/2016"),
                CityName = "Bebedouro",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 264,
                DateOfVisit = Convert.ToDateTime("07/19/2016"),
                CityName = "Barretos",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 265,
                DateOfVisit = Convert.ToDateTime("07/19/2016"),
                CityName = "Franca",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 266,
                DateOfVisit = Convert.ToDateTime("07/20/2016"),
                CityName = "Rio Claro",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 267,
                DateOfVisit = Convert.ToDateTime("07/20/2016"),
                CityName = "Limeira",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 268,
                DateOfVisit = Convert.ToDateTime("07/20/2016"),
                CityName = "Americana",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 269,
                DateOfVisit = Convert.ToDateTime("07/20/2016"),
                CityName = "Campinas",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 270,
                DateOfVisit = Convert.ToDateTime("07/21/2016"),
                CityName = "Indaiatuba",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 271,
                DateOfVisit = Convert.ToDateTime("07/21/2016"),
                CityName = "Itu",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 272,
                DateOfVisit = Convert.ToDateTime("07/21/2016"),
                CityName = "Jundiaí",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 273,
                DateOfVisit = Convert.ToDateTime("07/21/2016"),
                CityName = "Osasco",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 274,
                DateOfVisit = Convert.ToDateTime("07/22/2016"),
                CityName = "Praia Grande",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 275,
                DateOfVisit = Convert.ToDateTime("07/22/2016"),
                CityName = "São Vicente",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 276,
                DateOfVisit = Convert.ToDateTime("07/22/2016"),
                CityName = "Guarujá",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 277,
                DateOfVisit = Convert.ToDateTime("07/22/2016"),
                CityName = "Santos",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 278,
                DateOfVisit = Convert.ToDateTime("07/23/2016"),
                CityName = "Guarulhos",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 279,
                DateOfVisit = Convert.ToDateTime("07/23/2016"),
                CityName = "São Caetano do Sul",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 280,
                DateOfVisit = Convert.ToDateTime("07/23/2016"),
                CityName = "Santo André",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 281,
                DateOfVisit = Convert.ToDateTime("07/23/2016"),
                CityName = "São Bernado do Campo",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 282,
                DateOfVisit = Convert.ToDateTime("07/24/2016"),
                CityName = "São Paulo",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 283,
                DateOfVisit = Convert.ToDateTime("07/26/2016"),
                CityName = "Suzano",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 284,
                DateOfVisit = Convert.ToDateTime("07/26/2016"),
                CityName = "Mogi das Cruzes",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 285,
                DateOfVisit = Convert.ToDateTime("07/26/2016"),
                CityName = "Jacareí",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 286,
                DateOfVisit = Convert.ToDateTime("07/26/2016"),
                CityName = "São José dos Campos",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 287,
                DateOfVisit = Convert.ToDateTime("07/27/2016"),
                CityName = "Taubaté",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 288,
                DateOfVisit = Convert.ToDateTime("07/27/2016"),
                CityName = "São Luiz do Paraitinga",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 289,
                DateOfVisit = Convert.ToDateTime("07/27/2016"),
                CityName = "Ubatuba",
                State = SP,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 290,
                DateOfVisit = Convert.ToDateTime("07/27/2016"),
                CityName = "Paraty",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 291,
                DateOfVisit = Convert.ToDateTime("07/27/2016"),
                CityName = "Angra dos Reis",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 292,
                DateOfVisit = Convert.ToDateTime("07/28/2016"),
                CityName = "Rio Claro",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 293,
                DateOfVisit = Convert.ToDateTime("07/28/2016"),
                CityName = "Resende",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 294,
                DateOfVisit = Convert.ToDateTime("07/28/2016"),
                CityName = "Barra Mansa",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 295,
                DateOfVisit = Convert.ToDateTime("07/28/2016"),
                CityName = "Volta Redonda",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 296,
                DateOfVisit = Convert.ToDateTime("07/29/2016"),
                CityName = "Piraí",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 297,
                DateOfVisit = Convert.ToDateTime("07/29/2016"),
                CityName = "Barra do Piraí",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 298,
                DateOfVisit = Convert.ToDateTime("07/29/2016"),
                CityName = "Vassouras",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 299,
                DateOfVisit = Convert.ToDateTime("07/29/2016"),
                CityName = "Paraíba do Sul",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 300,
                DateOfVisit = Convert.ToDateTime("07/29/2016"),
                CityName = "Três Rios",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 301,
                DateOfVisit = Convert.ToDateTime("07/29/2016"),
                CityName = "Petrópolis",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 302,
                DateOfVisit = Convert.ToDateTime("07/30/2016"),
                CityName = "Teresópolis",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 303,
                DateOfVisit = Convert.ToDateTime("07/30/2016"),
                CityName = "Guapimirim",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 304,
                DateOfVisit = Convert.ToDateTime("07/30/2016"),
                CityName = "Cachoeiras de Macacu",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 305,
                DateOfVisit = Convert.ToDateTime("07/30/2016"),
                CityName = "Nova Friburgo",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 306,
                DateOfVisit = Convert.ToDateTime("07/31/2016"),
                CityName = "Cordeiro",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 307,
                DateOfVisit = Convert.ToDateTime("07/31/2016"),
                CityName = "Itaocara",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 308,
                DateOfVisit = Convert.ToDateTime("07/31/2016"),
                CityName = "São Fidélis",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 309,
                DateOfVisit = Convert.ToDateTime("07/31/2016"),
                CityName = "Campo dos Goytacazes",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 310,
                DateOfVisit = Convert.ToDateTime("07/31/2016"),
                CityName = "Conceição de Macabu",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 311,
                DateOfVisit = Convert.ToDateTime("07/31/2016"),
                CityName = "Macaé",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 312,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "Rio das Ostras",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 313,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "Búzios",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 314,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "São Pedro da Almeida",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 315,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "Iguaba Grande",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 316,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "Araruama",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 317,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "Arraial do Cabo",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 318,
                DateOfVisit = Convert.ToDateTime("08/01/2016"),
                CityName = "Cabo Frio",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 319,
                DateOfVisit = Convert.ToDateTime("08/02/2016"),
                CityName = "Saquarema",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 320,
                DateOfVisit = Convert.ToDateTime("08/02/2016"),
                CityName = "Rio Bonito",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 321,
                DateOfVisit = Convert.ToDateTime("08/02/2016"),
                CityName = "Tanguá",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 322,
                DateOfVisit = Convert.ToDateTime("08/02/2016"),
                CityName = "Itaboraí",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 323,
                DateOfVisit = Convert.ToDateTime("08/02/2016"),
                CityName = "São Gonçalo",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 324,
                DateOfVisit = Convert.ToDateTime("08/02/2016"),
                CityName = "Niterói",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 325,
                DateOfVisit = Convert.ToDateTime("08/03/2016"),
                CityName = "Duque de Caxias",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 326,
                DateOfVisit = Convert.ToDateTime("08/03/2016"),
                CityName = "São João de Meriti",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 327,
                DateOfVisit = Convert.ToDateTime("08/03/2016"),
                CityName = "Nilópolis",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 328,
                DateOfVisit = Convert.ToDateTime("08/03/2016"),
                CityName = "Belford Roxo",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 329,
                DateOfVisit = Convert.ToDateTime("08/03/2016"),
                CityName = "Nova Iguaçu",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 330,
                DateOfVisit = Convert.ToDateTime("08/04/2016"),
                CityName = "Rio de Janeiro",
                State = RJ,
                Description = "App secreto, dia 01/03",
            },
            new Item()
            {
                Id = 331,
                DateOfVisit = Convert.ToDateTime("08/05/2016"),
                CityName = "Rio de Janeiro",
                State = RJ,
                Description = "App secreto, dia 01/03",
            }
        };

        public static IList<Item> GetAllItems()
        {
            return _items;
        }

        public static Item GetItemById(int id)
        {
            return _items[id];
        }
    }
}
