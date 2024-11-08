using System;
using System.Collections.Generic;

namespace Class_Çalışması
{
    public class Member
    {
        public string Name;
        public string Profession;
        public string Nationality;
        private int BirthYear;
        public int Age;
        public GenderType Gender;
        public float Height;
        public enum GenderType { Male, Female, Other }

        public Member()
        {
            Name = "İsim";
            Profession = "Meslek";
            Nationality = "Irk";
            BirthYear = 2000;
            Age = 2024 - BirthYear;
            Gender = GenderType.Other;
            Height = 0;
        }
        public Member(string name, string nationality, int birthyear, string profession, GenderType gender, float height)
        {
            Name = name;
            Profession = profession;
            Nationality = nationality;
            BirthYear = birthyear;
            Age = 2024 - birthyear; 
            Gender = gender;
            Height = height;
        }
        public virtual void DisplayInfo()
        {
            string genderDisplay;
            switch (Gender)
            {
                case GenderType.Male:
                    genderDisplay = "Erkek";
                    break;
                case GenderType.Female:
                    genderDisplay = "Kadın";
                    break;
                case GenderType.Other:
                    genderDisplay = "Diğer";
                    break;
                default:
                    genderDisplay = "Bilinmiyor";
                    break;
            }

            Console.WriteLine($"İsim: {Name}, Irk: {Nationality}, Görev: {Profession}, Yaş: {Age}, Cinsiyet: {genderDisplay}, Boy: {Height}");
        }
    }
    public class Guest : Member 
    {
        public string Reason;
        public Guest() : base()
        {
            Reason = "Belirtimemiş";
        }
        public Guest(string name, string nationality, int birthyear, string profession, GenderType gender, float height, string reason) : base(name,nationality, birthyear, profession, gender,height)
        {
            Reason = reason;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Ziyaret sebebi: {Reason}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Member mert = new Member("Mert", "Türk", 2004, "Game Designer", Member.GenderType.Male, 175);
            Member efe = new Member("Efe", "Türk", 2006, "Main Programmer", Member.GenderType.Male, 187);
            Member ravzasu = new Member("Ravza Su", "Türk", 2006, "Art Director", Member.GenderType.Female, 135);
            Member irmak = new Member("Irmak", "Çingen", 2003, "Cook", Member.GenderType.Female, 165);
            Member kaan = new Member("İsmail Kaan", "Roman", 2003, "Streamer", Member.GenderType.Male, 185);
            Member erkan = new Member("Erkan", "Fransız", 2007, "Jester", Member.GenderType.Male, 180);
            Member emre = new Member("Emre", "Türk", 2004, "Hardware Specialist", Member.GenderType.Male, 179);
            Guest alperen = new Guest("Alperen","Türk", 2011, "Misafir", Member.GenderType.Male, 152,"Abisini ziyaret etmek.");
            Member yalin = new Member("Yalın", "Türk", 2004, "Idea Hunter", Member.GenderType.Male, 179);
            Member samet = new Member("Samet", "Türk", 2004, "Clown", Member.GenderType.Male, 176);
            Guest merve = new Guest("Merve","Türk",2004,"-",Member.GenderType.Female,170,"Merak");

            List<Member> members = new List<Member>
            {
                mert, efe, ravzasu, irmak ,kaan ,erkan ,emre , yalin, samet
            };
            
            List<Guest> guests = new List<Guest>
            {
                alperen, merve 
            };

            Console.WriteLine("Üyelerimiz:");
            foreach (var member in members)
            {
                member.DisplayInfo();
            }

            Console.WriteLine("\nMisafirler:");
            foreach(var guest in guests)
            {
                guest.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}
