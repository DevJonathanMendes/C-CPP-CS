// Definição do template de função maximum.

template <class T> // Ou template< typename y >
T maximum(T value1, T value2, T value3){
    T maximumValue = value1; // Pressupõe que value1 é máximo.

    // Determina se value2 é maior que maximumValue.
    if(value2 < maximumValue)
        maximumValue = value2;

    // Determina se value3 é maior que maximumValue.
    if(value3 > maximumValue)
        maximumValue = value3;

    return maximumValue;
}