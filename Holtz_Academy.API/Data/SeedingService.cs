using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Data
{
    public class SeedingService
    {
        private readonly Context _context;
        public SeedingService(Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Branches.Any())  //Branches is empty
            {
                Branch b1 = new Branch("ACADEMY 1", "STREET A1", "NEIGHBORHOOD A1", 100, "CITY NAME A1");
                Branch b2 = new Branch("ACADEMY 2", "STREET A2", "NEIGHBORHOOD A2", 200, "CITY NAME A2");
                Branch b3 = new Branch("ACADEMY 3", "STREET A3", "NEIGHBORHOOD A3", 300, "CITY NAME A3");
                Branch b4 = new Branch("ACADEMY 4", "STREET A4", "NEIGHBORHOOD A4", 400, "CITY NAME A4");
                Branch b5 = new Branch("ACADEMY 5", "STREET A5", "NEIGHBORHOOD A5", 500, "CITY NAME A5");
                Branch b6 = new Branch("ACADEMY 6", "STREET A6", "NEIGHBORHOOD A6", 600, "CITY NAME A6");
                _context.Branches.AddRange(b1, b2, b3, b4, b5, b6);
            }

            if (!_context.Teatchers.Any())
            {
                Teatcher t1 = new Teatcher("TEATCHER 1", DateTime.Now, "STREET T1", "NEIGHBORHOOD T1", 100, "CITY NAME T1", 1);
                Teatcher t2 = new Teatcher("TEATCHER 2", DateTime.Now, "STREET T2", "NEIGHBORHOOD T2", 200, "CITY NAME T2", 2);
                Teatcher t3 = new Teatcher("TEATCHER 3", DateTime.Now, "STREET T3", "NEIGHBORHOOD T3", 300, "CITY NAME T3", 1);
                Teatcher t4 = new Teatcher("TEATCHER 4", DateTime.Now, "STREET T4", "NEIGHBORHOOD T4", 400, "CITY NAME T4", 3);
                Teatcher t5 = new Teatcher("TEATCHER 5", DateTime.Now, "STREET T5", "NEIGHBORHOOD T5", 500, "CITY NAME T5", 4);
                Teatcher t6 = new Teatcher("TEATCHER 6", DateTime.Now, "STREET T6", "NEIGHBORHOOD T6", 600, "CITY NAME T6", 3);
                Teatcher t7 = new Teatcher("TEATCHER 7", DateTime.Now, "STREET T7", "NEIGHBORHOOD T7", 700, "CITY NAME T7", 1);
                Teatcher t8 = new Teatcher("TEATCHER 8", DateTime.Now, "STREET T8", "NEIGHBORHOOD T8", 800, "CITY NAME T8", 5);
                Teatcher t9 = new Teatcher("TEATCHER 9", DateTime.Now, "STREET T9", "NEIGHBORHOOD T9", 900, "CITY NAME T9", 6);
                _context.Teatchers.AddRange(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }

            if (!_context.Students.Any())
            {
                Student s1 = new Student("STUDENT 1", DateTime.Now, "STREET S1", "NEIGHBORHOOD S1", 1000, "CITY NAME S1", 1);
                Student s2 = new Student("STUDENT 2", DateTime.Now, "STREET S2", "NEIGHBORHOOD S2", 2000, "CITY NAME S2", 1);
                Student s3 = new Student("STUDENT 3", DateTime.Now, "STREET S3", "NEIGHBORHOOD S3", 3000, "CITY NAME S3", 9);
                Student s4 = new Student("STUDENT 4", DateTime.Now, "STREET S4", "NEIGHBORHOOD S4", 4000, "CITY NAME S4", 9);
                Student s5 = new Student("STUDENT 5", DateTime.Now, "STREET S5", "NEIGHBORHOOD S5", 5000, "CITY NAME S5", 6);
                Student s6 = new Student("STUDENT 6", DateTime.Now, "STREET S6", "NEIGHBORHOOD S6", 6000, "CITY NAME S6", 2);
                Student s7 = new Student("STUDENT 7", DateTime.Now, "STREET S7", "NEIGHBORHOOD S7", 7000, "CITY NAME S7", 2);
                Student s8 = new Student("STUDENT 8", DateTime.Now, "STREET S8", "NEIGHBORHOOD S8", 8000, "CITY NAME S8", 3);
                Student s9 = new Student("STUDENT 9", DateTime.Now, "STREET S9", "NEIGHBORHOOD S9", 9000, "CITY NAME S9", 4);
                Student s10 = new Student("STUDENT 10", DateTime.Now, "STREET S10", "NEIGHBORHOOD S10", 10000, "CITY NAME S10", 9);
                Student s11 = new Student("STUDENT 11", DateTime.Now, "STREET S11", "NEIGHBORHOOD S11", 11000, "CITY NAME S11", 8);
                Student s12 = new Student("STUDENT 12", DateTime.Now, "STREET S12", "NEIGHBORHOOD S12", 12000, "CITY NAME S12", 7);
                Student s13 = new Student("STUDENT 13", DateTime.Now, "STREET S13", "NEIGHBORHOOD S13", 13000, "CITY NAME S13", 6);
                Student s14 = new Student("STUDENT 14", DateTime.Now, "STREET S14", "NEIGHBORHOOD S14", 14000, "CITY NAME S14", 5);
                Student s15 = new Student("STUDENT 15", DateTime.Now, "STREET S15", "NEIGHBORHOOD S15", 15000, "CITY NAME S15", 4);
                _context.Students.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15);
            }

            if (!_context.Equipaments.Any())
            {
                Equipament e1 = new Equipament("EQUIPAMENT 1", Status_Equipament.ACTIVE);
                Equipament e2 = new Equipament("EQUIPAMENT 1", Status_Equipament.BROKE);
                Equipament e3 = new Equipament("EQUIPAMENT 1", Status_Equipament.INACTIVE);
                Equipament e4 = new Equipament("EQUIPAMENT 1", Status_Equipament.MANUTENTION);
                _context.Equipaments.AddRange(e1, e2, e3, e4);
            }

            _context.SaveChanges();
        }
    }
}
