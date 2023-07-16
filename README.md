**RPrime-Function**

> The function R(k) is essentially an infinite sum series involving the prime numbers. This series appears to converge to a value around ***1.7052301717918***. This series doesn't seem to be known in the math community, so I named it the RPrime-Function (reciprocal-prime-function). 

The RPrime function R(k) is formally defined below:

Given the helper function Q(x):

$$
Q(x) = \prod_{i=1}^{x}{p_i}
$$

$$
\text{where } {p_i} \text{ is the } {ith} \text{ prime number.}
$$

R(k) can be defined as follows:

$$
R(k) = 1 + \sum_{n=1}^{k} \frac{1}{Q(n)}
$$

R(k) can be further modified to the following form:

$$
R(k) = 1 + \sum_{n=1}^{k} \frac{1}{Q(n)}
$$

I propose the value of the function *R(k)* will converge to a value *r* as *k* approahces infinity:

$$
\lim_{{k \to \infty}}R(k) = r
$$

Experiemnetally r &asymp; *1.7052301717918*

git add .
git commit -m "updated formula"
git push origin main