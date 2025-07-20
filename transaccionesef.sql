-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-07-2025 a las 07:32:08
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `transaccionesef`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext NOT NULL,
  `Correo` longtext NOT NULL,
  `Saldo` decimal(65,30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombre`, `Correo`, `Saldo`) VALUES
(1, 'Juan Pérez', 'juan.perez@email.com', 500.000000000000000000000000000000),
(2, 'María García', 'maria.garcia@email.com', 1200.500000000000000000000000000000),
(3, 'Carlos López', 'carlos.lopez@email.com', 250.750000000000000000000000000000),
(4, 'Ana Martínez', 'ana.martinez@email.com', 800.300000000000000000000000000000),
(5, 'Luis Gómez', 'luis.gomez@email.com', 1450.100000000000000000000000000000),
(6, 'Laura Fernández', 'laura.fernandez@email.com', 300.000000000000000000000000000000),
(7, 'Roberto Díaz', 'roberto.diaz@email.com', 650.600000000000000000000000000000),
(8, 'Pedro Sánchez', 'pedro.sanchez@email.com', 920.000000000000000000000000000000),
(9, 'Sofía Rodríguez', 'sofia.rodriguez@email.com', 560.750000000000000000000000000000),
(10, 'Diego Jiménez', 'diego.jimenez@email.com', 1340.900000000000000000000000000000),
(11, 'Isabel García', 'isabel.garcia@email.com', 980.450000000000000000000000000000),
(12, 'Ricardo Martínez', 'ricardo.martinez@email.com', 750.300000000000000000000000000000),
(13, 'Elena López', 'elena.lopez@email.com', 1140.200000000000000000000000000000),
(14, 'Francisco Pérez', 'francisco.perez@email.com', 1325.600000000000000000000000000000),
(15, 'Javier Fernández', 'javier.fernandez@email.com', 650.800000000000000000000000000000),
(16, 'Victoria Gómez', 'victoria.gomez@email.com', 390.550000000000000000000000000000),
(17, 'Gabriel Rodríguez', 'gabriel.rodriguez@email.com', 275.400000000000000000000000000000),
(18, 'Patricia López', 'patricia.lopez@email.com', 1440.100000000000000000000000000000),
(19, 'Fernando Pérez', 'fernando.perez@email.com', 410.600000000000000000000000000000),
(20, 'Carmen Sánchez', 'carmen.sanchez@email.com', 525.800000000000000000000000000000),
(21, 'Álvaro Martínez', 'alvaro.martinez@email.com', 250.750000000000000000000000000000),
(22, 'Raquel Díaz', 'raquel.diaz@email.com', 185.900000000000000000000000000000),
(23, 'Luis Fernández', 'luis.fernandez@email.com', 870.400000000000000000000000000000),
(24, 'Sandra López', 'sandra.lopez@email.com', 1020.300000000000000000000000000000),
(25, 'Carlos González', 'carlos.gonzalez@email.com', 340.250000000000000000000000000000),
(26, 'Marina Jiménez', 'marina.jimenez@email.com', 570.100000000000000000000000000000),
(27, 'Jorge Sánchez', 'jorge.sanchez@email.com', 810.600000000000000000000000000000),
(28, 'Beatriz Fernández', 'beatriz.fernandez@email.com', 1255.800000000000000000000000000000),
(29, 'Julio Ruiz', 'julio.ruiz@email.com', 360.450000000000000000000000000000),
(30, 'Inés Rodríguez', 'ines.rodriguez@email.com', 680.900000000000000000000000000000),
(31, 'José Gómez', 'jose.gomez@email.com', 1000.750000000000000000000000000000),
(32, 'Esther López', 'esther.lopez@email.com', 210.550000000000000000000000000000),
(33, 'Martín Sánchez', 'martin.sanchez@email.com', 430.250000000000000000000000000000),
(34, 'Natalia Pérez', 'natalia.perez@email.com', 1375.300000000000000000000000000000),
(35, 'Pedro López', 'pedro.lopez@email.com', 660.500000000000000000000000000000),
(36, 'Marta Gómez', 'marta.gomez@email.com', 1220.600000000000000000000000000000),
(37, 'Ana Ruiz', 'ana.ruiz@email.com', 870.250000000000000000000000000000),
(38, 'Pablo González', 'pablo.gonzalez@email.com', 360.300000000000000000000000000000),
(39, 'Mercedes Rodríguez', 'mercedes.rodriguez@email.com', 1090.400000000000000000000000000000),
(40, 'Antonio Fernández', 'antonio.fernandez@email.com', 520.150000000000000000000000000000),
(41, 'Luis Martínez', 'luis.martinez@email.com', 775.200000000000000000000000000000),
(42, 'Nuria Sánchez', 'nuria.sanchez@email.com', 1455.700000000000000000000000000000),
(43, 'Andrés López', 'andres.lopez@email.com', 330.600000000000000000000000000000),
(44, 'Juan Antonio Díaz', 'juan.antonio.diaz@email.com', 680.300000000000000000000000000000),
(45, 'Cecilia Ruiz', 'cecilia.ruiz@email.com', 965.000000000000000000000000000000),
(46, 'Rafael Martínez', 'rafael.martinez@email.com', 540.100000000000000000000000000000),
(47, 'Eva González', 'eva.gonzalez@email.com', 1230.500000000000000000000000000000),
(48, 'Alfredo Rodríguez', 'alfredo.rodriguez@email.com', 100.750000000000000000000000000000),
(49, 'Cristina Sánchez', 'cristina.sanchez@email.com', 1500.900000000000000000000000000000),
(50, 'Tomás Pérez', 'tomas.perez@email.com', 800.450000000000000000000000000000),
(51, 'Victoria Jiménez', 'victoria.jimenez@email.com', 520.250000000000000000000000000000),
(52, 'Antonio González', 'antonio.gonzalez@email.com', 1095.300000000000000000000000000000),
(53, 'Bea García', 'bea.garcia@email.com', 645.800000000000000000000000000000),
(54, 'Luis Ruiz', 'luis.ruiz@email.com', 820.150000000000000000000000000000),
(55, 'José Antonio Rodríguez', 'jose.antonio.rodriguez@email.com', 350.900000000000000000000000000000),
(56, 'Francisca Díaz', 'francisca.diaz@email.com', 1305.700000000000000000000000000000),
(57, 'Valeria Fernández', 'valeria.fernandez@email.com', 9909630.750000000000000000000000000000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20250720051542_Inicial', '8.0.17');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
