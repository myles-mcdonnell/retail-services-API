package com.nedap.retail.messages.article;

import java.io.Serializable;

import org.codehaus.jackson.map.annotate.JsonSerialize;

@JsonSerialize(include = JsonSerialize.Inclusion.NON_NULL)
public class Size implements Serializable {
    private String description;
    private String region;

    public Size() {
    }

    public Size(final String description, final String region) {
        this.description = description;
        this.region = region;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(final String description) {
        this.description = description;
    }

    public String getRegion() {
        return region;
    }

    public void setRegion(final String region) {
        this.region = region;
    }

    @Override
    public String toString() {
        return "[" + region + "|" + description + "]";
    }
}