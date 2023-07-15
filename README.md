**RPrime-Function**

> This a function R(k) that is essentially an infinite sum series involving the prime numbers. This series seems to converge to a value around *1.7052301717918*. This series doesn't seem to be known in the math community, so I named the RPrime-Function (reciprocal-prime-function).

Given the helper function Q(x), R(k) can be defined as follows:

$$
Q(x) = \prod_{i=1}^{x}{p_i}
$$

$$
\text{where } {p_i} \text{ is the } {ith} \text{ prime number.}
$$

$$
R(k) = 1 + \sum_{n=1}^{k} \frac{1}{Q(n)}
$$


