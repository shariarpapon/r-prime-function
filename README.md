**RPrime-Function**

> This a function R(k) that is essentially an infinite sum series involving the prime numbers. This series seems to converge to a value around *1.7052301717918*. This series doesn't seem to be known in the math community, so I named the RPrime-Function (reciprocal-prime-function).

The function R(k) can be defined using a helper function Q(x) as follows:

$$
Q(x) = \prod_{i=1}^{i=x}{p_i}
$$

$$
R(k) = 1 + \sum_{n=1}^{n=k} \frac{1}{Q(n)}
$$



