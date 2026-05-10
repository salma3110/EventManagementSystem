-- Step 1: clean slate
DELETE FROM EntryPass;
DELETE FROM GatheringStaff;
DELETE FROM EntryClass;
DELETE FROM Gathering;
DELETE FROM Staff;
DELETE FROM Patron;
DELETE FROM Venue;

DBCC CHECKIDENT ('Venue',      RESEED, 0);
DBCC CHECKIDENT ('Patron',     RESEED, 0);
DBCC CHECKIDENT ('Staff',      RESEED, 0);
DBCC CHECKIDENT ('Gathering',  RESEED, 0);
DBCC CHECKIDENT ('EntryClass', RESEED, 0);
DBCC CHECKIDENT ('EntryPass',  RESEED, 0);

-- Step 2: Venues
INSERT INTO Venue (name, street_name, city, capacity) VALUES
('Grand Hall',   'Alharam Street', 'Giza',  1000),
('Blue Lounge',  'Tahrir Square',  'Cairo',  500),
('Sky Arena',    'Corniche Road',  'Cairo', 2000),
('Desert Stage', 'October City',   'Giza',   800);

-- Step 3: Patrons
INSERT INTO Patron (fname, lname, email, phone_number, password_hash) VALUES
('Ahmed',   'Hassan',  'ahmed@mail.com',   '0101111111', 'defaultpass'),
('Sara',    'Ali',     'sara@mail.com',    '0102222222', 'defaultpass'),
('Mohamed', 'Khaled',  'mohamed@mail.com', '0103333333', 'defaultpass'),
('Nour',    'Ibrahim', 'nour@mail.com',    '0104444444', 'defaultpass'),
('Omar',    'Tarek',   'omar@mail.com',    '0105555555', 'defaultpass');

-- Step 4: Staff
INSERT INTO Staff (fname, lname) VALUES
('Layla', 'Mostafa'),
('Karim', 'Samir'),
('Dina',  'Fawzy');

-- Step 5: Gatherings
INSERT INTO Gathering (title, date, category, venue_id) VALUES
('Rock Night',       '2026-04-05', 'Music',     1),
('Business Summit',  '2026-04-10', 'Corporate', 2),
('Jazz Evening',     '2026-04-15', 'Music',     3),
('Silent Gathering', '2026-04-20', 'Corporate', 4);

-- Step 6: Entry Classes (ONE insert only, 8 rows total)
-- class_id 1 = Rock Night Premium
-- class_id 2 = Rock Night Standard
-- class_id 3 = Rock Night Balcony
-- class_id 4 = Business Summit Premium
-- class_id 5 = Business Summit Standard
-- class_id 6 = Jazz Evening Premium
-- class_id 7 = Jazz Evening Standard
-- class_id 8 = Desert Stage VIP (NO passes will be sold for this)
INSERT INTO EntryClass (class_name, price, seats_allocation, gathering_id) VALUES
('Premium',  500.00, 100, 1),
('Standard', 200.00, 400, 1),
('Balcony',  150.00, 500, 1),
('Premium',  800.00,  50, 2),
('Standard', 400.00, 200, 2),
('Premium',  600.00, 200, 3),
('Standard', 250.00, 800, 3),
('VIP',     1000.00,  50, 4);

-- Step 7: Gathering Staff
INSERT INTO GatheringStaff (gathering_id, staff_id, role) VALUES
(1, 1, 'Coordinator'),
(1, 2, 'Primary Technician'),
(2, 1, 'Coordinator'),
(2, 3, 'Primary Technician'),
(3, 2, 'Coordinator'),
(3, 3, 'Staff'),
(4, 1, 'Coordinator');

-- Step 8: Entry Passes (NO pass for class_id 8 = Desert Stage VIP)
INSERT INTO EntryPass (purchase_date, patron_id, class_id) VALUES
('2026-04-06', 1, 1),
('2026-04-11', 1, 5),
('2026-04-06', 2, 2),
('2026-04-06', 3, 3),
('2026-04-16', 3, 6),
('2026-04-16', 4, 7);



