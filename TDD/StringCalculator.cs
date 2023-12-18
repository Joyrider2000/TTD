namespace TTD;

public class StringCalculator {
    public int Add(string numbers) {
        if (numbers == string.Empty) {
            return 0;
        }
        char[] delimiters = { ',', '\n' };
        foreach (var delimiter  in delimiters) {
            numbers = numbers.Replace(delimiter, delimiters[0]);
        }
        var numberList = numbers.Split(delimiters[0]);

        int sum = 0;
        foreach ( var number in numberList ) {
            sum += int.Parse(number);
        }
        return sum;
    }
}

