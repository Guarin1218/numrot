using System;
using backend.Enums;

namespace backend.Common
{
    static class Constants
    {
        public const string ONLY_LETTERS_MSG = "Por favor ingresa solo letras. Los números no están permitidos";   
        public const string DOCUMENT_NUMBER_REQUIRED_MSG = "El número de documento es requerido";
        public const string DOCUMENT_NUMBER_MAX_LENGTH_MSG = "El tamaño del documentso es de máximo 20 dígitos";
        public const string FIRST_NAME_REQUIRED_MSG = "El primer nombre es requerido";
        public const string FIRST_NAME_MAX_LENGTH_MSG = "El tamaño del primer nombre es de máximo 40 caracteres";
        public const string MIDDLE_NAME_MAX_LENGTH_MSG = "El tamaño del segundo nombre es de máximo 40 caracteres";
        public const string FIRST_SURNAME_REQUIRED_MSG = "El primer apellido es requerido";
        public const string FIRST_SURNAME_MAX_LENGTH_MSG = "El tamaño del primer apellido es de máximo 40 caracteres";
        public const string SECOND_SURNAME_MAX_LENGTH_MSG = "El tamaño del segundo apellido es de máximo 40 caracteres";
        public const string PHONE_NUMBER_MAX_LENGTH_MSG = "El tamaño del número de teléfono es de máximo 20 dígitos";
        public const string EMAIL_FORMAT_MSG = "El correo tiene que ser un formato válido";
        public const string EMAIL_MAX_LENGTH_MSG= "El tamaño del correo es de máximo 200 dígitos";
        public const string ADDRESS_REQUIRED_MSG = "La dirección es requerida";
        public const string AGE_REQUIRED_MSG = "La edad es requerida";
        public const string AGE_MAX_LENGTH = "El tamaño de la edad es de máximo 3 dígitos";
        public const string GENDER_REQUIRED_MSG = "El género es requerido";
        public const string AGE_ENUM_MSG = "Solo puedes elegir entre estos géneros: 1 - masculino, 2 - femenino";
        public const string ONLY_LETTERS_REGEX = @"^[a-zA-Z\s]+$";

    }
}

