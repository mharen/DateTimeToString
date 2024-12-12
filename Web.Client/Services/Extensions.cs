namespace Web.Client.Services;

public static partial class Extensions
{

    public static string FillMicroseconds(this string formattedDate, string fakeMicroseconds)
    {
        // wasm/JS dates don't have precision beyond the millisecond so we fake it by replacing the zeros
        // we get there with fake microseconds
        var index = formattedDate.LastIndexOf("0000");
        if (index < 0)
            return formattedDate;

        return string.Concat(formattedDate.AsSpan(0, index), fakeMicroseconds, formattedDate.AsSpan(index + 4));
    }
}
// 012340000
// len = 9
