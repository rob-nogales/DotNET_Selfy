﻿using Microsoft.ML.Data;
namespace HousePriceAPI.DataModels
{
    public class TexasPriceData
    {
        [ColumnName("id"), LoadColumn(0)]
        public float Id { get; set; }


        [ColumnName("date"), LoadColumn(1)]
        public string Date { get; set; }


        [ColumnName("price"), LoadColumn(2)]
        public float Price { get; set; }


        [ColumnName("bedrooms"), LoadColumn(3)]
        public float Bedrooms { get; set; }


        [ColumnName("bathrooms"), LoadColumn(4)]
        public float Bathrooms { get; set; }


        [ColumnName("sqft_living"), LoadColumn(5)]
        public float Sqft_living { get; set; }


        [ColumnName("sqft_lot"), LoadColumn(6)]
        public float Sqft_lot { get; set; }


        [ColumnName("floors"), LoadColumn(7)]
        public float Floors { get; set; }


        [ColumnName("waterfront"), LoadColumn(8)]
        public float Waterfront { get; set; }


        [ColumnName("view"), LoadColumn(9)]
        public float View { get; set; }


        [ColumnName("condition"), LoadColumn(10)]
        public float Condition { get; set; }


        [ColumnName("grade"), LoadColumn(11)]
        public float Grade { get; set; }


        [ColumnName("sqft_above"), LoadColumn(12)]
        public float Sqft_above { get; set; }


        [ColumnName("sqft_basement"), LoadColumn(13)]
        public float Sqft_basement { get; set; }


        [ColumnName("yr_built"), LoadColumn(14)]
        public float Yr_built { get; set; }


        [ColumnName("yr_renovated"), LoadColumn(15)]
        public float Yr_renovated { get; set; }


        [ColumnName("zipcode"), LoadColumn(16)]
        public float Zipcode { get; set; }


        [ColumnName("lat"), LoadColumn(17)]
        public float Lat { get; set; }


        [ColumnName("long"), LoadColumn(18)]
        public float Long { get; set; }


        [ColumnName("sqft_living15"), LoadColumn(19)]
        public float Sqft_living15 { get; set; }


        [ColumnName("sqft_lot15"), LoadColumn(20)]
        public float Sqft_lot15 { get; set; }


    }

}
