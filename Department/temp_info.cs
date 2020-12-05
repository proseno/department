using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    class temp_info
    {
        public static person select_person;
        public static benefits select_benefits;

        public static person select_person_workers;
        public static position select_position_workers;
        public static cech select_cech_workers;

        public static workers select_workers;
        public static goods select_goods;
        public static storage select_storage;
        public static supplier select_supplier;

        public static person person_search;
        public static position position_search;
        public static cech cech_search;
        public static benefits benefits_search;
        public static goods goods_search;
        public static supplier supplier_search;
        public static storage storage_search;

        public static person_benefits person_benefits_search;
        public static person_benefits person_benefits_NUM;

        public static workers workers_search;
        public static Nullable<int> workers_personNUM;
        public static Nullable<int> workers_cechNUM;
        public static Nullable<int> workers_positionNUM;

        public static delivery delivery_search;
        public static Nullable<int> delivery_workerNUM;
        public static Nullable<int> delivery_goodsNUM;
        public static Nullable<int> delivery_supplierNUM;
        public static Nullable<int> delivery_storageNUM;

    }
}
