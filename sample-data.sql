-- Sample data for Einventory, the same data shown in the screenshots.
-- Run it after Einventory.sql, in SQL Server Management Studio.
-- Log in with admin / admin123 (or mahmoud / mahmoud123).

USE [Einventory]
GO

INSERT INTO users (username, password) VALUES ('admin', 'admin123'), ('mahmoud', 'mahmoud123');
GO

INSERT INTO stockin (product_name, inti_price, category, quntity, deposit, expire, last_update, admin_username) VALUES
  ('Samsung 24" Monitor', 4200, 'Electronics', 10, '10/3/2026', 'None', '10/6/2026', 'mahmoud'),
  ('Logitech Wireless Mouse', 350, 'Electronics', 6, '11/7/2026', 'None', '11/7/2026', 'admin'),
  ('HP LaserJet Toner 85A', 1150, 'Electronics', 4, '8/31/2026', 'None', '9/1/2026', 'admin'),
  ('USB-C Charger 25W', 420, 'Electronics', 24, '11/2/2026', 'None', '11/5/2026', 'admin'),
  ('Ethernet Cable 5m', 95, 'Electronics', 6, '10/14/2026', 'None', '10/17/2026', 'admin'),
  ('A4 Copy Paper (box)', 310, 'Stationery', 50, '7/31/2026', 'None', '7/31/2026', 'admin'),
  ('Blue Ballpoint Pens (50)', 120, 'Stationery', 60, '8/25/2026', 'None', '8/25/2026', 'mahmoud'),
  ('Sticky Notes Pack', 60, 'Stationery', 24, '8/31/2026', 'None', '8/31/2026', 'admin'),
  ('Cardboard Boxes Large', 28, 'Packaging', 40, '11/8/2026', 'None', '11/9/2026', 'admin'),
  ('Packing Tape 48mm', 22, 'Packaging', 10, '9/21/2026', 'None', '9/21/2026', 'mahmoud'),
  ('Bubble Wrap Roll', 180, 'Packaging', 40, '10/5/2026', 'None', '10/6/2026', 'admin'),
  ('Bottled Water 1.5L (6)', 45, 'Food', 60, '8/31/2026', '10/17/2027', '9/1/2026', 'admin'),
  ('Instant Coffee 200g', 160, 'Food', 80, '11/1/2026', '12/6/2027', '11/1/2026', 'mahmoud'),
  ('Tea Bags (100)', 75, 'Food', 12, '11/6/2026', '1/16/2028', '11/9/2026', 'mahmoud'),
  ('Sugar 1kg', 30, 'Food', 100, '9/6/2026', '8/10/2027', '9/8/2026', 'admin'),
  ('Hand Sanitizer 500ml', 65, 'Cleaning', 20, '8/31/2026', '8/18/2027', '9/2/2026', 'admin'),
  ('Floor Cleaner 3L', 90, 'Cleaning', 80, '8/4/2026', '3/4/2027', '8/5/2026', 'admin'),
  ('Trash Bags (50)', 55, 'Cleaning', 15, '9/1/2026', 'None', '9/4/2026', 'admin'),
  ('Cordless Drill 18V', 1850, 'Tools', 30, '8/12/2026', 'None', '8/14/2026', 'mahmoud'),
  ('Screwdriver Set', 240, 'Tools', 6, '11/4/2026', 'None', '11/7/2026', 'admin'),
  ('Safety Gloves (pair)', 40, 'Tools', 20, '8/9/2026', 'None', '8/10/2026', 'admin'),
  ('Pallet Jack', 9800, 'Equipment', 4, '9/21/2026', 'None', '9/21/2026', 'mahmoud'),
  ('Steel Shelf Unit', 2600, 'Equipment', 100, '9/1/2026', 'None', '9/3/2026', 'admin'),
  ('Hand Truck', 1400, 'Equipment', 20, '8/17/2026', 'None', '8/20/2026', 'mahmoud');
GO

-- items that already went out (their id is the stock in id they had)
INSERT INTO stockout (id, product_name, inti_price, category, quntity, deposit, expire, last_update, admin_username) VALUES
  (100, 'Samsung 24" Monitor', 4200, 'Electronics', 24, '10/3/2026', 'None', '11/1/2026', 'mahmoud'),
  (102, 'HP LaserJet Toner 85A', 1150, 'Electronics', 8, '8/31/2026', 'None', '11/13/2026', 'admin'),
  (104, 'Ethernet Cable 5m', 95, 'Electronics', 16, '10/14/2026', 'None', '11/13/2026', 'admin'),
  (106, 'Blue Ballpoint Pens (50)', 120, 'Stationery', 160, '8/25/2026', 'None', '11/7/2026', 'mahmoud'),
  (108, 'Cardboard Boxes Large', 28, 'Packaging', 104, '11/8/2026', 'None', '10/31/2026', 'admin'),
  (110, 'Bubble Wrap Roll', 180, 'Packaging', 104, '10/5/2026', 'None', '11/13/2026', 'admin'),
  (112, 'Instant Coffee 200g', 160, 'Food', 208, '11/1/2026', '12/6/2027', '11/14/2026', 'mahmoud');
GO
