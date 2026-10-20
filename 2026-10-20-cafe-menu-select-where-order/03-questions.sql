-- All drinks, cheapest first.
SELECT * FROM menu_items WITH (NOLOCK) WHERE category = 'drinks' ORDER BY price ASC

-- Everything that's sold out.
SELECT * FROM menu_items WITH (NOLOCK) WHERE stock = 0

-- Items from R30 to R50 (inclusive), most expensive first.
SELECT * FROM menu_items WITH (NOLOCK) WHERE price >= 30 AND price <= 50 ORDER BY price DESC

-- Anything with "coffee" in the name, whatever the casing
SELECT * FROM menu_items WITH (NOLOCK) WHERE name LIKE '%coffee%'

-- Items that have no supplier on record.
SELECT * FROM menu_items WITH (NOLOCK) WHERE supplier IS NULL

-- Mains or snacks that are still in stock, grouped by category, then cheapest first.
-- SELECT category, price FROM menu_items WITH (NOLOCK) WHERE category IN ('main', 'snacks') GROUP BY category ORDER BY price ASC

-- The three most expensive items.
SELECT TOP(3) * FROM menu_items ORDER BY price DESC

-- Page 2 of the menu, 4 items per page, alphabetical by name.
-- not sure

-- Everything added in the first quarter of 2026 (1 January to 31 March).
