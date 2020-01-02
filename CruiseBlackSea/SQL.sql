--creates tables for Cruise database
CREATE TABLE AppUser 
(
	ID_user int NOT NULL PRIMARY KEY,
	last_name varchar(255),
	first_name varchar(255),
	address_user varchar(1000),
	email_address varchar(255) UNIQUE(email_address),
	phone_number varchar(14) UNIQUE(phone_number),
	password_user varchar(100) CHECK (DATALENGTH(password_user) > 5),
	grant_user tinyint CHECK(grant_user = 0 OR grant_user = 1) DEFAULT 0 --0 for normal user and 1 for admin
);

CREATE TABLE Harbour (
	ID_harbour int NOT NULL PRIMARY KEY,
	harbour_name varchar(255),
	position_x int,
	position_y int
);

CREATE TABLE Distance (
	ID_harbour_source int FOREIGN KEY REFERENCES Harbour(ID_harbour),
	ID_harbour_dest int FOREIGN KEY REFERENCES Harbour(ID_harbour),
	harbour_name_dest varchar(255),
	distance int
);

CREATE TABLE Cruise (
	ID_cruise int NOT NULL PRIMARY KEY,
	type_cruise int, --possible values are 3, 5, 8
	harbour_list varchar(30),
	date_start Date,
	date_end Date,
	price real,
	number_passengers int
);
--insert a normal user with grant_user code 0
INSERT INTO AppUser (ID_user, last_name, first_name, address_user, email_address, phone_number, password_user, grant_user, user_name_app) VALUES (
1,
'Popescu',
'Ionel',
'Craiova, Calea Bucuresti',
'pop@yahoo.com',
'0745654762',
'pop_pop',
0,
'pop_user');

--add an user name in AppUser table
ALTER TABLE AppUser ADD user_name_app varchar(100) NOT NULL;

--insert a few cruises
INSERT INTO cruise.dbo.Cruise VALUES (1, 3, '1 5 7 11', '2019-10-10', '2019-11-10', 1000, 2);
INSERT INTO cruise.dbo.Cruise VALUES (2, 5, '1 5 7 11', '2019-10-10', '2019-10-15', 5000, 4);
INSERT INTO cruise.dbo.Cruise VALUES (3, 8, '1 5 7 11', '2019-10-10', '2019-10-18', 432, 2);
INSERT INTO cruise.dbo.Cruise VALUES (4, 3, '1 5 7 11', '2019-10-10', '2019-10-13', 10000, 10);

--insert harbours coordinates
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (1, 'Constanta', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (2, 'Varna', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (3, 'Burgas', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (4, 'Istanbul', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (5, 'Kozlu', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (6, 'Samsun', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (7, 'Batumi', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (8, 'Sokhumi', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (9, 'Sochi', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (10, 'Anapa', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (11, 'Ialta', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (12, 'Sevastopol', 94, 216);
INSERT INTO cruise.dbo.Harbour (ID_harbour, harbour_name, position_x, position_y) VALUES (13, 'Odessa', 94, 216);

--update coordinates for harbours because I inserted all same Constanta
UPDATE cruise.dbo.Harbour SET position_x = 52, position_y = 293 WHERE harbour_name = 'Varna'
UPDATE cruise.dbo.Harbour SET position_x = 26, position_y = 347 WHERE harbour_name = 'Burgas'
UPDATE cruise.dbo.Harbour SET position_x = 115, position_y = 464 WHERE harbour_name = 'Istanbul'
UPDATE cruise.dbo.Harbour SET position_x = 279, position_y = 432 WHERE harbour_name = 'Kozlu'
UPDATE cruise.dbo.Harbour SET position_x = 550, position_y = 443 WHERE harbour_name = 'Samsun'
UPDATE cruise.dbo.Harbour SET position_x = 866, position_y = 415 WHERE harbour_name = 'Batumi'
UPDATE cruise.dbo.Harbour SET position_x = 826, position_y = 308 WHERE harbour_name = 'Sokhumi'
UPDATE cruise.dbo.Harbour SET position_x = 753, position_y = 265 WHERE harbour_name = 'Sochi'
UPDATE cruise.dbo.Harbour SET position_x = 610, position_y = 159 WHERE harbour_name = 'Anapa'
UPDATE cruise.dbo.Harbour SET position_x = 422, position_y = 190 WHERE harbour_name = 'Ialta'
UPDATE cruise.dbo.Harbour SET position_x = 385, position_y = 181 WHERE harbour_name = 'Sevastopol'
UPDATE cruise.dbo.Harbour SET position_x = 220, position_y = 27 WHERE harbour_name = 'Odessa'

--insert distances between every harbour
--Source harbour is Constanta
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 1, 'Constanta', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 2, 'Varna', 176);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 3, 'Burgas', 244);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 4, 'Istanbul', 366);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 5, 'Kozlu', 397);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 6, 'Samsun', 742);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 7, 'Batumi', 1099);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 8, 'Sokhumi', 1008);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 9, 'Sochi', 892);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 10, 'Anapa', 718);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 11, 'Ialta', 466);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 12, 'Sevastopol', 394);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (1, 13, 'Odessa', 305);
--Source harbour is Varna
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 1, 'Constanta', 176);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 2, 'Varna', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 3, 'Burgas', 118);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 4, 'Istanbul', 272);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 5, 'Kozlu', 368);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 6, 'Samsun', 769);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 7, 'Batumi', 1139);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 8, 'Sokhumi', 1064);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 9, 'Sochi', 952);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 10, 'Anapa', 775);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 11, 'Ialta', 520);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 12, 'Sevastopol', 478);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (2, 13, 'Odessa', 476);
--Source harbour is Burgas
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 1, 'Constanta', 248);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 2, 'Varna', 118);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 3, 'Burgas', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 4, 'Istanbul', 230);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 5, 'Kozlu', 373);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 6, 'Samsun', 816);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 7, 'Batumi', 1171);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 8, 'Sokhumi', 1108);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 9, 'Sochi', 1003);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 10, 'Anapa', 836);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 11, 'Ialta', 591);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 12, 'Sevastopol', 542);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (3, 13, 'Odessa', 557);
--Source harbour is Istanbul
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 1, 'Constanta', 366);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 2, 'Varna', 272);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 3, 'Burgas', 230);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 4, 'Istanbul', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 5, 'Kozlu', 249);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 6, 'Samsun', 730);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 7, 'Batumi', 1093);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 8, 'Sokhumi', 1033);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 9, 'Sochi', 936);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 10, 'Anapa', 807);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 11, 'Ialta', 579);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 12, 'Sevastopol', 548);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (4, 13, 'Odessa', 644);
--Source harbour is Kozlu
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 1, 'Constanta', 397);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 2, 'Varna', 368);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 3, 'Burgas', 373);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 4, 'Istanbul', 249);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 5, 'Kozlu', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 6, 'Samsun', 487);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 7, 'Batumi', 857);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 8, 'Sokhumi', 801);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 9, 'Sochi', 712);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 10, 'Anapa', 596);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 11, 'Ialta', 394);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 12, 'Sevastopol', 394);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (5, 13, 'Odessa', 577);
--Source harbour is Samsun
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 1, 'Constanta', 742);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 2, 'Varna', 769);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 3, 'Burgas', 816);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 4, 'Istanbul', 730);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 5, 'Kozlu', 487);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 6, 'Samsun', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 7, 'Batumi', 454);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 8, 'Sokhumi', 436);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 9, 'Sochi', 382);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 10, 'Anapa', 411);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 11, 'Ialta', 400);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 12, 'Sevastopol', 475);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (6, 13, 'Odessa', 739);
--Source harbour is Batumi
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 1, 'Constanta', 1099);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 2, 'Varna', 1139);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 3, 'Burgas', 1171);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 4, 'Istanbul', 1093);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 5, 'Kozlu', 857);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 6, 'Samsun', 454);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 7, 'Batumi', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 8, 'Sokhumi', 158);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 9, 'Sochi', 273);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 10, 'Anapa', 510);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 11, 'Ialta', 684);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 12, 'Sevastopol', 788);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (7, 13, 'Odessa', 1054);
--Source harbour is Sokhumi
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 1, 'Constanta', 1008);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 2, 'Varna', 1064);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 3, 'Burgas', 1108);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 4, 'Istanbul', 1033);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 5, 'Kozlu', 801);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 6, 'Samsun', 436);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 7, 'Batumi', 158);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 8, 'Sokhumi', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 9, 'Sochi', 150);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 10, 'Anapa', 389);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 11, 'Ialta', 576);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 12, 'Sevastopol', 673);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (8, 13, 'Odessa', 945);
--Source harbour is Sochi
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 1, 'Constanta', 892);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 2, 'Varna', 952);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 3, 'Burgas', 1003);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 4, 'Istanbul', 936);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 5, 'Kozlu', 712);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 6, 'Samsun', 382);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 7, 'Batumi', 273);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 8, 'Sokhumi', 150);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 9, 'Sochi', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 10, 'Anapa', 248);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 11, 'Ialta', 450);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 12, 'Sevastopol', 551);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (9, 13, 'Odessa', 825);
--Source harbour is Anapa
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 1, 'Constanta', 718);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 2, 'Varna', 775);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 3, 'Burgas', 836);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 4, 'Istanbul', 807);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 5, 'Kozlu', 596);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 6, 'Samsun', 411);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 7, 'Batumi', 510);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 8, 'Sokhumi', 389);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 9, 'Sochi', 248);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 10, 'Anapa', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 11, 'Ialta', 252);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 12, 'Sevastopol', 371);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (10, 13, 'Odessa', 639);
--Source harbour is Ialta
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 1, 'Constanta', 466);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 2, 'Varna', 520);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 3, 'Burgas', 591);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 4, 'Istanbul', 579);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 5, 'Kozlu', 394);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 6, 'Samsun', 400);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 7, 'Batumi', 684);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 8, 'Sokhumi', 576);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 9, 'Sochi', 450);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 10, 'Anapa', 252);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 11, 'Ialta', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 12, 'Sevastopol', 117);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (11, 13, 'Odessa', 392);
--Source harbour is Sevastopol
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 1, 'Constanta', 394);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 2, 'Varna', 478);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 3, 'Burgas', 542);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 4, 'Istanbul', 548);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 5, 'Kozlu', 394);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 6, 'Samsun', 475);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 7, 'Batumi', 788);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 8, 'Sokhumi', 673);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 9, 'Sochi', 551);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 10, 'Anapa', 371);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 11, 'Ialta', 117);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 12, 'Sevastopol', 0);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (12, 13, 'Odessa', 305);
--Source harbour is Odessa
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 1, 'Constanta', 305);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 2, 'Varna', 476);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 3, 'Burgas', 557);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 4, 'Istanbul', 644);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 5, 'Kozlu', 577);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 6, 'Samsun', 739);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 7, 'Batumi', 1054);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 8, 'Sokhumi', 945);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 9, 'Sochi', 825);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 10, 'Anapa', 639);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 11, 'Ialta', 392);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 12, 'Sevastopol', 305);
INSERT INTO cruise.dbo.Distance (ID_harbour_source, ID_harbour_dest, harbour_name_dest, distance) VALUES (13, 13, 'Odessa', 0);