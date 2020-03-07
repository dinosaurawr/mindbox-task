## SCHEME ##

CREATE TABLE products
	(id int, name varchar(120))
;
	
INSERT INTO products
	(id, name)
VALUES
	(1, 'Product 1'),
	(2, 'Product 2'),
	(3, 'Product 3'),
    (4, 'Product 4')
;

CREATE TABLE categories
	(id int, category varchar(60))
;
	
INSERT INTO categories
	(id, category)
VALUES
	(1, 'Category 1'),
	(2, 'Category 2'),
	(3, 'Category 3')
;

CREATE TABLE product_category
	(product_id int, category_id int)
;
	
INSERT INTO product_category
	(product_id, category_id)
VALUES
	(3, 1),
	(1, 2),
	(2, 2),
	(2, 3),
	(3, 3)
;

## REQUEST ##

SELECT 
  products.name, categories.category
FROM
  products
LEFT JOIN
  product_category
ON
  product_category.product_id = products.id
LEFT JOIN
  categories
ON
  categories.id = product_category.category_id