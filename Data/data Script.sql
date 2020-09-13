
select * from hotel_bookings

select distinct reservation_status from hotel_bookings


select id, hotel, lead_time, arrival_date_month, arrival_date_week_number, arrival_date_day_of_month, 
stays_in_weekend_nights, stays_in_week_nights, adults, children, babies, meal, country, market_segment,
distribution_channel, is_repeated_guest, previous_cancellations, previous_bookings_not_canceled,
reserved_room_type, assigned_room_type, booking_changes, days_in_waiting_list, customer_type,
adr, required_car_parking_spaces, total_of_special_requests, reservation_status
from hotel_bookings
where id not in (
select id from hotel_bookings_batch
)

select * INTO hotel_bookings_batch
from (
select top 10 id, hotel, lead_time, arrival_date_month, arrival_date_week_number, arrival_date_day_of_month, 
stays_in_weekend_nights, stays_in_week_nights, adults, children, babies, meal, country, market_segment,
distribution_channel, is_repeated_guest, previous_cancellations, previous_bookings_not_canceled,
reserved_room_type, assigned_room_type, booking_changes, days_in_waiting_list, customer_type,
adr, required_car_parking_spaces, total_of_special_requests, reservation_status
from hotel_bookings 
where reservation_status = 'Check-Out'
UNION 
select top 10 id, hotel, lead_time, arrival_date_month, arrival_date_week_number, arrival_date_day_of_month, 
stays_in_weekend_nights, stays_in_week_nights, adults, children, babies, meal, country, market_segment,
distribution_channel, is_repeated_guest, previous_cancellations, previous_bookings_not_canceled,
reserved_room_type, assigned_room_type, booking_changes, days_in_waiting_list, customer_type,
adr, required_car_parking_spaces, total_of_special_requests, reservation_status
from hotel_bookings
where reservation_status = 'Booking-Changed'
UNION 
select top 10 id, hotel, lead_time, arrival_date_month, arrival_date_week_number, arrival_date_day_of_month, 
stays_in_weekend_nights, stays_in_week_nights, adults, children, babies, meal, country, market_segment,
distribution_channel, is_repeated_guest, previous_cancellations, previous_bookings_not_canceled,
reserved_room_type, assigned_room_type, booking_changes, days_in_waiting_list, customer_type,
adr, required_car_parking_spaces, total_of_special_requests, reservation_status
from hotel_bookings
where reservation_status = 'Canceled'
) tabla 

--drop table hotel_bookings_batch

select * from hotel_bookings_batch
