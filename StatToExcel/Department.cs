namespace StatToExcel
{
    public class Department
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
    }

    public class DepartmentList
    {
        private static Department[] _departments;

        public Department[] Departments => _departments;

        public DepartmentList()
        {
            _departments = new Department[54];

            for(var i = 0; i <= _departments.Length - 1; i++)
                _departments[i] = new Department();

            _departments[0].Id = 1;
            _departments[0].Name = "АГАПОВСКИЙ";

            _departments[1].Id = 2;
            _departments[1].Name = "В - УРАЛЬСКИЙ";

            _departments[2].Id = 3;
            _departments[2].Name = "ЕМАНЖЕЛИНСК";

            _departments[3].Id = 4;
            _departments[3].Name = "АРГАЯШСКИЙ";

            _departments[4].Id = 5;
            _departments[4].Name = "ВАРНЕНСКИЙ";

            _departments[5].Id = 6;
            _departments[5].Name = "ЕТКУЛЬСКИЙ";

            _departments[6].Id = 7;
            _departments[6].Name = "ЗЛАТОУСТ";

            _departments[7].Id = 8;
            _departments[7].Name = "АШИНСКИЙ";

            _departments[8].Id = 9;
            _departments[8].Name = "БРЕДИНСКИЙ";

            _departments[9].Id = 10;
            _departments[9].Name = "КАРАБАШ";

            _departments[10].Id = 11;
            _departments[10].Name = "КАРТАЛЫ";

            _departments[11].Id = 12;
            _departments[11].Name = "КАСЛИНСКИЙ";

            _departments[12].Id = 13;
            _departments[12].Name = "К - ИВАНОВСК";

            _departments[13].Id = 14;
            _departments[13].Name = "КИЗИЛЬСКИЙ";

            _departments[14].Id = 15;
            _departments[14].Name = "КОПЕЙСК";

            _departments[15].Id = 16;
            _departments[15].Name = "КОРКИНО";

            _departments[16].Id = 17;
            _departments[16].Name = "КРАСНОАРМЕЙСКИЙ";

            _departments[17].Id = 18;
            _departments[17].Name = "КУНАШАКСКИЙ";

            _departments[18].Id = 19;
            _departments[18].Name = "КУСИНСКИЙ";

            _departments[19].Id = 20;
            _departments[19].Name = "КЫШТЫМСКИЙ";

            _departments[20].Id = 21;
            _departments[20].Name = "МАГНИТОГОРСК";

            _departments[21].Id = 22;
            _departments[21].Name = "МИАСС";

            //_departments[22].Id = 23;
            //_departments[22].Name = "МАГНИТОГОРСК ПРАВОБЕРЕЖНЫЙ";

            _departments[22].Id = 24;
            _departments[22].Name = "НАГАЙБАКСКИЙ";

            //_departments[24].Id = 25;
            //_departments[24].Name = "МАГНИТОГОРСК ЛЕНИНСКИЙ";

            //_departments[25].Id = 26;
            //_departments[25].Name = "МАГНИТОГОРСК ОРДЖОНИКИДЗЕНСКИЙ";

            //_departments[26].Id = 55;
            //_departments[26].Name = "МАГНИТОГОРСК ОБДПС";

            _departments[23].Id = 27;
            _departments[23].Name = "НЯЗЕПЕТРОВСКИЙ";

            _departments[24].Id = 28;
            _departments[24].Name = "ОЗЕРСКИЙ";

            _departments[25].Id = 29;
            _departments[25].Name = "ОКТЯБРЬСКИЙ";

            _departments[26].Id = 30;
            _departments[26].Name = "ПЛАСТ";

            _departments[27].Id = 31;
            _departments[27].Name = "САТКИНСКИЙ";

            _departments[28].Id = 32;
            _departments[28].Name = "СНЕЖИНСКИЙ";

            _departments[29].Id = 33;
            _departments[29].Name = "СОСНОВСКИЙ";

            _departments[30].Id = 34;
            _departments[30].Name = "ТРЕХГОРНЫЙ";

            _departments[31].Id = 36;
            _departments[31].Name = "ТРОИЦКИЙ";

            _departments[32].Id = 37;
            _departments[32].Name = "УВЕЛЬСКИЙ";

            _departments[33].Id = 38;
            _departments[33].Name = "УЙСКИЙ";

            _departments[34].Id = 39;
            _departments[34].Name = "УСТЬ - КАТАВ";

            _departments[35].Id = 40;
            _departments[35].Name = "УФАЛЕЙСКИЙ";

            _departments[36].Id = 41;
            _departments[36].Name = "ЧЕБАРКУЛЬСКИЙ";

            _departments[37].Id = 42;
            _departments[37].Name = "ЧЕСМЕНСКИЙ";

            _departments[38].Id = 43;
            _departments[38].Name = "ЮЖНОУРАЛЬСК";
            
            //_departments[43].Id = 44;
            //_departments[43].Name = "ЧЕЛЯБИНСК";

            //_departments[44].Id = 45;
            //_departments[44].Name = "ЧЕЛЯБИНСК КАЛИНИНСКИЙ";

            //_departments[45].Id = 46;
            //_departments[45].Name = "ЧЕЛЯБИНСК ЛЕНИНСКИЙ";

            //_departments[46].Id = 47;
            //_departments[46].Name = "ЧЕЛЯБИНСК МЕТАЛЛУРГИЧЕСКИЙ";

            //_departments[47].Id = 48;
            //_departments[47].Name = "ЧЕЛЯБИНСК СОВЕТСКИЙ";

            //_departments[48].Id = 49;
            //_departments[48].Name = "ЧЕЛЯБИНСК ТРАКТОРОЗАВОДСКИЙ";

            //_departments[49].Id = 50;
            //_departments[49].Name = "ЧЕЛЯБИНСК ЦЕНРАЛЬНЫЙ";

            //_departments[50].Id = 51;
            //_departments[50].Name = "ЧЕЛЯБИНСК КУРЧАТОВСКИЙ";

            _departments[39].Id = 52;
            _departments[39].Name = "ЧЕЛЯБИНСК ПОЛК ДПС";

            _departments[40].Id = 53;
            _departments[40].Name = "УГАИ";

            _departments[41].Id = 54;
            _departments[41].Name = "ПОЛК ДПС ГИБДД ГУ МВД ПО ЧЕЛЯБИНСКОЙ ОБЛ";

            //56  "МИАССКИЙ ОРДПС
            //57  "ЗЛАТОУСТ ОРДПС
            //59  "КАРТАЛЫ - 6
            //72  "ЧЕЛЯБИНСК ВИДЕОМОНИТОРИНГ
            //74  "ЦЕНТР ВИДЕОМОНИТОРИНГА УГИБДД
            //75  "МАГНИТОГОРСК ВИДЕОМОНИТОРИНГ

        }
    }
}