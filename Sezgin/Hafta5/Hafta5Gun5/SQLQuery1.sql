CREATE TABLE booksales (
  country VARCHAR(35), 
  genre varchar(20) NOT NULL CHECK (genre IN('fiction', 'non-fiction')), 
  year DATE, 
  sales INT
)

INSERT INTO booksales VALUES
  ('Senegal','fiction','2014',12234), ('Senegal','fiction','2015',15647),
  ('Senegal','non-fiction','2014',64980), ('Senegal','non-fiction','2015',78901),
  ('Paraguay','fiction','2014',87970), ('Paraguay','fiction','2015',76940),
  ('Paraguay','non-fiction','2014',8760), ('Paraguay','non-fiction','2015',9030)