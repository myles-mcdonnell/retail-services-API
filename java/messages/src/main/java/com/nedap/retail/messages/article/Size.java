package com.nedap.retail.messages.article;

import java.io.Serializable;

public class Size implements Serializable {

    private static final long serialVersionUID = -1475858032925556829L;

    public String description;
    public String region;

    public Size() {
    }

    public Size(final String description, final String region) {
        this.description = description;
        this.region = region;
    }

    @Override
    public String toString() {
        return "[" + region + "|" + description + "]";
    }
}
