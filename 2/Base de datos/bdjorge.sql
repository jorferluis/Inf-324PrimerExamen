-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-10-2024 a las 23:05:04
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdjorge`
--
CREATE DATABASE IF NOT EXISTS `bdjorge` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bdjorge`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--
-- Creación: 01-10-2024 a las 21:44:31
-- Última actualización: 04-10-2024 a las 14:59:26
--

CREATE TABLE `persona` (
  `ci` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `paterno` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`ci`, `nombre`, `paterno`) VALUES
(777, 'Luna', 'Perez'),
(12345678, 'Jose', 'Gonzalez'),
(87654321, 'Ana', 'Pérez');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `propiedades`
--
-- Creación: 03-10-2024 a las 20:42:20
-- Última actualización: 04-10-2024 a las 19:16:55
--

CREATE TABLE `propiedades` (
  `id` int(11) NOT NULL CHECK (`id` between 100000 and 300000),
  `descripcion` varchar(255) NOT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `zona` varchar(50) NOT NULL,
  `distrito` varchar(50) NOT NULL,
  `x_ini` decimal(10,6) NOT NULL,
  `y_ini` decimal(10,6) NOT NULL,
  `x_fin` decimal(10,6) NOT NULL,
  `y_fin` decimal(10,6) NOT NULL,
  `superficie` decimal(10,2) NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `ci` int(11) NOT NULL,
  `fecha_registro` timestamp NOT NULL DEFAULT current_timestamp()
) ;

--
-- Volcado de datos para la tabla `propiedades`
--

INSERT INTO `propiedades` (`id`, `descripcion`, `direccion`, `zona`, `distrito`, `x_ini`, `y_ini`, `x_fin`, `y_fin`, `superficie`, `precio`, `ci`, `fecha_registro`) VALUES
(100000, 'Edificio', 'Centro', 'Centro', 'Distrito 1', 1111.000000, 9999.000000, 8888.000000, 2222.000000, 100000.00, 1000000.00, 777, '2024-10-04 15:35:20'),
(100001, 'Casa en las afueras', 'Av. Siempre Viva 742', 'Sur', 'Distrito 2', -16.510000, -68.160000, -16.510050, -68.160050, 250.00, 200000.00, 777, '2024-10-04 19:16:55'),
(200000, 'Departamento moderno', 'Calle Falsa 456', 'Norte', 'Distrito 3', -16.520000, -68.170000, -16.520050, -68.170050, 85.00, 100000.00, 12345678, '2024-10-04 19:16:55'),
(300000, 'Propiedad en el centro', 'Calle 123', 'Centro', 'Distrito 1', -16.500000, -68.150000, -16.500050, -68.150050, 120.50, 150000.00, 87654321, '2024-10-04 18:13:07');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--
-- Creación: 04-10-2024 a las 14:26:44
-- Última actualización: 04-10-2024 a las 15:00:19
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `rol` enum('root','normal','funcionario') NOT NULL DEFAULT 'normal',
  `persona_id` int(11) DEFAULT NULL,
  `ci_persona` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `username`, `password`, `rol`, `persona_id`, `ci_persona`) VALUES
(1, 'root', '$2y$10$v8FCRNYo37Wb9NcLPwQ.CeLpIHeteqqQsOmwge2of7UZ0lZ8Mgx.2', 'root', NULL, NULL),
(2, 'ana', '$2y$10$Aefp34fPArCws3STcwGlp.rPlKEUcYZiMrtfzcx2ntFgRm3/dTo16', 'normal', NULL, 87654321),
(3, 'jose', '$2y$10$A0/GeOtfmzwRDVCuJq/tOeLf9ogkizaWIvPfcea4WtVzgkQds9qWG', 'funcionario', NULL, 12345678),
(13, 'luna', '$2y$10$8r5eJPERu5nSrWctVTlOwORTgyhAZbdjWTcrEHJYgqYK9KTt8ROgO', 'normal', NULL, 777);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`ci`);

--
-- Indices de la tabla `propiedades`
--
ALTER TABLE `propiedades`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ci` (`ci`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `fk_persona` (`persona_id`),
  ADD KEY `fk_ci_persona` (`ci_persona`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `propiedades`
--
ALTER TABLE `propiedades`
  ADD CONSTRAINT `propiedades_ibfk_1` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `fk_ci_persona` FOREIGN KEY (`ci_persona`) REFERENCES `persona` (`ci`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_persona` FOREIGN KEY (`persona_id`) REFERENCES `persona` (`ci`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
