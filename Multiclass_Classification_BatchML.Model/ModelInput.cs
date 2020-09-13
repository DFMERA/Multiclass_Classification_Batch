// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Multiclass_Classification_BatchML.Model
{
    public class ModelInput
    {
        [ColumnName("id"), LoadColumn(0)]
        public float Id { get; set; }


        [ColumnName("hotel"), LoadColumn(1)]
        public string Hotel { get; set; }


        [ColumnName("lead_time"), LoadColumn(2)]
        public float Lead_time { get; set; }


        [ColumnName("arrival_date_month"), LoadColumn(3)]
        public string Arrival_date_month { get; set; }


        [ColumnName("arrival_date_week_number"), LoadColumn(4)]
        public float Arrival_date_week_number { get; set; }


        [ColumnName("arrival_date_day_of_month"), LoadColumn(5)]
        public float Arrival_date_day_of_month { get; set; }


        [ColumnName("stays_in_weekend_nights"), LoadColumn(6)]
        public float Stays_in_weekend_nights { get; set; }


        [ColumnName("stays_in_week_nights"), LoadColumn(7)]
        public float Stays_in_week_nights { get; set; }


        [ColumnName("adults"), LoadColumn(8)]
        public float Adults { get; set; }


        [ColumnName("children"), LoadColumn(9)]
        public float Children { get; set; }


        [ColumnName("babies"), LoadColumn(10)]
        public float Babies { get; set; }


        [ColumnName("meal"), LoadColumn(11)]
        public string Meal { get; set; }


        [ColumnName("country"), LoadColumn(12)]
        public string Country { get; set; }


        [ColumnName("market_segment"), LoadColumn(13)]
        public string Market_segment { get; set; }


        [ColumnName("distribution_channel"), LoadColumn(14)]
        public string Distribution_channel { get; set; }


        [ColumnName("is_repeated_guest"), LoadColumn(15)]
        public float Is_repeated_guest { get; set; }


        [ColumnName("previous_cancellations"), LoadColumn(16)]
        public float Previous_cancellations { get; set; }


        [ColumnName("previous_bookings_not_canceled"), LoadColumn(17)]
        public float Previous_bookings_not_canceled { get; set; }


        [ColumnName("reserved_room_type"), LoadColumn(18)]
        public string Reserved_room_type { get; set; }


        [ColumnName("assigned_room_type"), LoadColumn(19)]
        public string Assigned_room_type { get; set; }


        [ColumnName("booking_changes"), LoadColumn(20)]
        public float Booking_changes { get; set; }


        [ColumnName("days_in_waiting_list"), LoadColumn(21)]
        public float Days_in_waiting_list { get; set; }


        [ColumnName("customer_type"), LoadColumn(22)]
        public string Customer_type { get; set; }


        [ColumnName("adr"), LoadColumn(23)]
        public float Adr { get; set; }


        [ColumnName("required_car_parking_spaces"), LoadColumn(24)]
        public float Required_car_parking_spaces { get; set; }


        [ColumnName("total_of_special_requests"), LoadColumn(25)]
        public float Total_of_special_requests { get; set; }


        [ColumnName("reservation_status"), LoadColumn(26)]
        public string Reservation_status { get; set; }


    }
}