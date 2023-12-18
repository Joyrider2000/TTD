namespace TTD;

public class StringCalculator {
    public int Add(string numbers) {
        if (numbers == string.Empty) {
            return 0;
        }
        var delimiter = ",";
        var numberList = numbers.Split(delimiter);

        int sum = 0;
        foreach ( var number in numberList ) {
            sum += int.Parse(number);
        }
        return sum;
    }
}

