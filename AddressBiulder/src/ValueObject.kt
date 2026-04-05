abstract class ValueObject<T>(
    protected val type: T,
    protected val value: String
) {
    abstract override fun toString(): String
}