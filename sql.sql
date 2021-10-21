## SCHEME ##

CREATE TABLE product (
	id int,
	name varchar(120),
	primary key(id)
);
	
INSERT INTO product
	(id, name)
VALUES
	(1, 'Product 1'),
	(2, 'Product 2'),
	(3, 'Product 3'),
    (4, 'Product 4')
;

CREATE TABLE category (
	id int,
	name varchar(120),
	primary key(id)
);
	
INSERT INTO category
	(id, name)
VALUES
	(1, 'Category 1'),
	(2, 'Category 2'),
	(3, 'Category 3')
;

CREATE TABLE product_category (
	product_id int,
	category_id int,
	constraint fk_product foreign key(product_id) references product(id)
);
	
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
  product.name, category.name
FROM
  product
LEFT JOIN
  product_category
ON
  product_category.product_id = product.id
LEFT JOIN
  category
ON
  category.id = product_category.category_id