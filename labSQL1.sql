CREATE TABLE my_table (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50)
);


ALTER TABLE my_table ADD COLUMN age INT;

INSERT INTO my_table (name, age) VALUES 
('A', 25),
('B', 30),
('C', 22),
('D', 35);

SELECT * FROM my_table;
SELECT * FROM my_table WHERE age >= 25;

CREATE PROCEDURE get_even_id_records()
SELECT * FROM my_table WHERE id % 2 = 0;

CALL get_even_id_records();

