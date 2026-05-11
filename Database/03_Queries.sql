--Inquiry 4: Patrons who registered but bought no passes last month
SELECT p.patron_id, p.fname, p.lname, p.email
FROM Patron p
WHERE p.patron_id NOT IN (
    SELECT ep.patron_id 
    FROM EntryPass ep
    WHERE MONTH(ep.purchase_date) = MONTH(GETDATE()) - 1
    AND   YEAR(ep.purchase_date)  = YEAR(GETDATE())
);

--Inquiry 6: Each patron's full info + total spent
SELECT 
    p.patron_id,
    p.fname,
    p.lname,
    p.email,
    p.phone_number,
    ISNULL(SUM(ec.price), 0) AS total_spent
FROM Patron p
LEFT JOIN EntryPass ep ON p.patron_id = ep.patron_id
LEFT JOIN EntryClass ec ON ep.class_id = ec.class_id
GROUP BY p.patron_id, p.fname, p.lname, p.email, p.phone_number;

-- Inquiry 2: Venue with no passes sold last month
SELECT DISTINCT v.name AS venue_name, g.title AS gathering_title
FROM Venue v
JOIN Gathering g ON v.venue_id = g.venue_id
WHERE MONTH(g.date) = MONTH(GETDATE()) - 1
AND   YEAR(g.date)  = YEAR(GETDATE())
AND g.gathering_id NOT IN (
    SELECT ec.gathering_id
    FROM EntryClass ec
    JOIN EntryPass ep ON ec.class_id = ep.class_id
    WHERE MONTH(ep.purchase_date) = MONTH(GETDATE()) - 1  
    AND   YEAR(ep.purchase_date)  = YEAR(GETDATE())
);

--Inquiry 5: Entry classes available per gathering last month
SELECT 
    g.title  AS gathering_title,
    ec.class_name,
    ec.price,
    ec.seats_allocation
FROM Gathering g
JOIN EntryClass ec ON g.gathering_id = ec.gathering_id
WHERE MONTH(g.date) = MONTH(GETDATE()) - 1
AND   YEAR(g.date)  = YEAR(GETDATE())
ORDER BY g.title, ec.class_name;


--Inquiry 1:category that sold the maximum number of entry passes
SELECT g.category,
       COUNT(ep.pass_id) AS total_passes
FROM Gathering g
JOIN EntryClass ec
    ON g.gathering_id = ec.gathering_id
JOIN EntryPass ep
    ON ec.class_id = ep.class_id
GROUP BY g.category
HAVING COUNT(ep.pass_id) = (
    SELECT MAX(pass_count)
    FROM (
        SELECT COUNT(ep.pass_id) AS pass_count
        FROM Gathering g
        JOIN EntryClass ec
            ON g.gathering_id = ec.gathering_id
        JOIN EntryPass ep
            ON ec.class_id = ep.class_id
        GROUP BY g.category
    ) AS counts
);