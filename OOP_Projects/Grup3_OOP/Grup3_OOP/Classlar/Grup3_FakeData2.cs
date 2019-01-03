using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup3_OOP.Classlar
{
    class Grup3_FakeData2
    {
        private static string[] _fNames = 
        { "Mary","Anna","Emma","Elizabeth","Minnie","Margaret","Ida","Alice","Bertha","Sarah","Annie","Clara","Ella","Florence",
        "Cora","Martha","Laura","Nellie","Grace","Carrie","Maude","Mabel","Bessie","Jennie","Gertrude","Julia","Hattie","Edith",
        "Mattie","Rose","Catherine","Lillian","Ada","Lillie","Helen","Jessie","Louise","Ethel","Lula","Myrtle","Eva","Frances",
        "Lena","Lucy","Edna","Maggie","Pearl","Daisy","Fannie","Josephine","Dora","Rosa","Katherine","Agnes","Marie","Nora",
        "May","Mamie","Blanche","Stella","Ellen","Nancy","Effie","Sallie","Nettie","Della","Lizzie","Flora","Susie","Maud",
        "Mae","Etta","Harriet","Sadie","Caroline","Katie","Lydia","Elsie","Kate","Susan","Mollie","Alma","Addie","Georgia",
        "Eliza","Lulu","Nannie","Lottie","Amanda","Belle","Charlotte","Rebecca","Ruth","Viola","Olive","Amelia","Hannah","Jane",
        "Virginia","Emily","Matilda","Irene","Kathryn","Esther","Willie","Henrietta","Ollie","Amy","Rachel","Sara","Estella",
        "Theresa","Augusta","Ora","Pauline","Josie","Lola","Sophia","Leona","Anne","Mildred","Ann","Beulah","Callie","Lou",
        "Delia","Eleanor","Barbara","Iva","Louisa","Maria","Mayme" };

        private static string[] _mNames = 
        { "John","William","James","Charles","George","Frank","Joseph","Thomas","Henry","Robert","Edward","Harry","Walter",
        "Arthur","Fred","Albert","Samuel","David","Louis","Joe","Charlie","Clarence","Richard","Andrew","Daniel","Ernest",
        "Will","Jesse","Oscar","Lewis","Peter","Benjamin","Frederick","Willie","Alfred","Sam","Roy","Herbert","Jacob","Tom",
        "Elmer","Carl","Lee","Howard","Martin","Michael","Bert","Herman","Jim","Francis","Harvey","Earl","Eugene","Ralph","Ed",
        "Claude","Edwin","Ben","Charley","Paul","Edgar","Isaac","Otto","Luther","Lawrence","Ira","Patrick","Guy","Oliver",
        "Theodore","Hugh","Clyde","Alexander","August","Floyd","Homer","Jack","Leonard","Horace","Marion","Philip","Allen",
        "Archie","Stephen","Chester","Willis","Raymond","Rufus","Warren","Jessie","Milton","Alex","Leo","Julius","Ray","Sidney",
        "Bernard","Dan","Jerry","Calvin","Perry","Dave","Anthony","Eddie","Amos","Dennis","Clifford","Leroy","Wesley","Alonzo",
        "Garfield","Franklin" };

        private static string[] _surnames = 
        { "Vissicchio","Vizueth","Voiselle","Volking","Volsky","Vondriska","Vonfricken","Vongpanya","Vorheis","Vradenburgh",
        "Vuelvas","Wady","Wagenhals","Walbolt","Waldkirch","Wantoch","Warin","Wasilenko","Waskowiak","Wattam","Wedington",
        "Weece","Wegscheider","Weisbard","Welmaker","Wenstrand","Wesh","Whapham","Widdoss","Wiethop","Willcoxson",
        "Williamsmae","Winek","Winnings","Wittern","Witwicki","Woodiel","Wooledge","Woolett","Worlton","Wrath",
        "Wrixon","Wrzesien","Wulfeck","Wyms","Yaccino","Yaggy","Yakim","Yapo","Yardy","Yaukey","Yerka","Yousko","Zadrima",
        "Zaft","Zaitsev","Zalabak","Zalla","Zanjani","Zanol","Zapka","Zeldes","Zerbey","Ziegelhofer","Zielesch","Zilk",
        "Zinnanti","Zitterich","Zulu","Zusi" };

        public static string[] GetMNames(){
            return _mNames;
        }

        public static string[] GetFNames(){
            return _fNames;
        }

        public static string[] GetSurnames(){
            return _surnames;
        }

        public static List<FakeData> GenerateRandomFullNames(int listSize){
            List<FakeData> fakeDatas = new List<FakeData>();
            Random r = new Random();

            for(int i = 0; i < listSize; i++) {
                int rGender = r.Next(0, 2);
                int rName;
                string name, surname;
                char gender;
                if(rGender == 0) {
                    rName = r.Next(0, _fNames.Length);
                    name = _fNames[rName];
                    gender = 'F';
                }
                else {
                    rName = r.Next(0, _mNames.Length);
                    name = _mNames[rName];
                    gender = 'M';
                }
                int rSurname = r.Next(0, _surnames.Length);
                surname = _surnames[rSurname];

                FakeData fakeData = new FakeData();
                fakeData.ID = i;
                fakeData.Name = name;
                fakeData.Surname = surname;
                fakeData.Gender = gender;

                fakeDatas.Add(fakeData);
            }

            return fakeDatas;
        }

        public class FakeData {
            public int ID { get; set;}
            public string Name { get; set; }
            public string Surname { get; set; }
            public char Gender { get; set; }
        }
    }
}