USE Autoexpo;

INSERT INTO EstadoAuto VALUES('Disponible'), ('Vendido');
SELECT * FROM EstadoAuto;

INSERT INTO Marca VALUES
('Audi'),
('BMW'),
('Cadillac'),
('Chevrolet'),
('Citroen'),
('Ferrari'),
('Ford'),
('General Motors'),
('Honda'),
('Hyundai'),
('Jeep'),
('Kia'),
('Lamborghini'),
('Land Rover'),
('Mazda'),
('McLaren'),
('Mercedes-Benz'),
('Mitsubishi'),
('Nissan'),
('Porsche'),
('Renault'),
('Suzuki'),
('Toyota'),
('Volkswagen'),
('Volvo');
SELECT * FROM Marca;

INSERT INTO Rol VALUES('Administrador'), ('Cliente');
SELECT * FROM Rol;

INSERT INTO Persona VALUES('12345', 'David', 'Rivas', 'david', 1), ('09876', 'Santiago', 'Agudelo', 'santiago', 2);
SELECT * FROM Persona;