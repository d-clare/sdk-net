
/**
 * Represents a duration
 */
export class Duration
 {
  /**
   * Gets/sets the numbers of days, if any
   */
  days: number | null;
  /**
   * Gets/sets the numbers of hours, if any
   */
  hours: number | null;
  /**
   * Gets/sets the numbers of minutes, if any
   */
  minutes: number | null;
  /**
   * Gets/sets the numbers of seconds, if any
   */
  seconds: number | null;
  /**
   * Gets/sets the numbers of milliseconds, if any
   */
  milliseconds: number | null;
  /**
   * Gets the the duration's total amount of days
   */
  totalDays: number;
  /**
   * Gets the the duration's total amount of hours
   */
  totalHours: number;
  /**
   * Gets the the duration's total amount of minutes
   */
  totalMinutes: number;
  /**
   * Gets the the duration's total amount of seconds
   */
  totalSeconds: number;
  /**
   * Gets the the duration's total amount of milliseconds
   */
  totalMilliseconds: number;
}