# Git Commit Standard

See [License](https://github.com//jeffdoolittle/git-with-it/blob/main/LICENSE) for copyright and usage information.

Following this Git Commit Standard provides many benefits:

* Enables consistent and coherent documentation for each commit.
* Provides a source to generate clean and clear release notes.
* Aids in code review processes.
* Integrates well with issue tracking systems.
* Follows best practices for subject and body line lengths.

## Subject

Begin commit messages with a `subject` line that:

* is written in the *imperative* mood.
* is a full sentence capitalized and *ends with a period*.
* completes the sentence `"*Applying this commit will* [Fix the nasty bug.|Enable the cool capability.|Upgrade the dependencies.]".`
* is limited to **50** characters.
* ends with a *blank line* before beginning the `reference` (or `body` that includes the `reference)`.
* does *not* include a `reference` to an `issue` (continue reading).

## Reference

Include a `reference` to the `issue` (or task, or story, etc.) number that:

* follows the format `"[References|Closes|Completes|Fixes|{Other}] #{issue-number}"`
  * `issue-number` must be a valid reference to a tracking system `issue` in the format `#nnnn` where `nnnn` is an arbitrary length integer value.
  * *avoid* using tracking system specific references, such as `GH-nnnn` for GitHub.
* does *not* end with a period.
* ends with a blank line before beginning the `body`.

Alternatively the `reference` line may be skipped on the condition that:

* the reference is included in the `body`.

## Body

Continue the commit message with a `body` that:

* begins with a blank line between the `reference` and the `body` (as stated previously).
* wraps at 72 characters.
* explains *what and why*, not how.
* conveys technical empathy to the next engineer who will have to work with, on, or in the codebase—which could quite likely be you! See [Future Homer](https://www.youtube.com/watch?v=jQvvmT3ab80).

## Summary

To summarize the standard visually, consider the following templates.

### Template 1

```text
Imperative sentence len <= 50 ending with period.

[References|Closes|Completes|Fixes|{Other}] #{issue-number}

A long form body describing the what and why, not the how, and wrapping
every line at <= 72 characters.
```

### Template 2

```text
Imperative sentence len <= 50 ending with period.

A long form body describing the what and why, not the how, and wrapping
every line at <= 72 characters while including a reference to the
issue this commit applies to in the format #nnnn.
```

## Examples

```text
Initialize the basic service infrastructure.

References #1000

The basic service infrastructure forms the foundation for ongoing
development. This includes all necessary contracts and configurations
as discussed in the relevant design documents.
```

```text
Fix the nasty bug.

That nasty bug as described in #1001 has finally been smashed! Woo hoo!
```

&copy; 2020 Jeff Doolittle. All Rights Reserved.
